using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Guard : Patrol
{
    [SerializeField]
    protected Transform patrolPointBeforePlayerSeen;

    protected override void Start()
    {
        base.Start();
    }

    protected override void InstantiateAPatrolPoint(bool start = false)
    {
        Transform go = Instantiate(patrolPoint, body.position, Quaternion.identity);
        go.transform.SetParent(patrolPointParent.transform);
        if (start)
        {
            patrolPoints.Insert(0, go);
        }
        else
        {
            patrolPointBeforePlayerSeen = go;
        }
    }

    protected override void MoveTo(Transform point, int count, bool returnToPoint = false)
    {
        if (Vector3.Distance(body.position, point.position) <= 0.5f)
        {
            if (returnToPoint)
            {
                Destroy(patrolPointBeforePlayerSeen.gameObject);
                patrolPointBeforePlayerSeen = null;
            }
            else
            {
                NewPoint(patrolLoop, count);
            }
        }
    }

    protected override IEnumerator PatrolMovement()
    {
        InstantiateAPatrolPoint(true);
        while (this.gameObject.activeSelf)
        {
            if (eventPatrols.Count > 0)
            {
                if (currentEventPatrol.Count == 0)
                {
                    foreach (EventPatrol ep in eventPatrols)
                    {
                        if (DayClock.Instance.CurrentDay == ep.specificDay || ep.specificDay == 0)
                        {
                            //Debug.Log(DayClock.Instance.FillAmount + " == " + ep.TimeToProc);
                            if (DayClock.Instance.FillAmount == ep.TimeToProc)
                            {
                                currentPoint = 0;
                                currentEventPatrol.Add(ep);
                            }
                        }
                    }
                }
                else
                {
                    if (Vector3.Distance(body.position, currentEventPatrol[0].patrolPoints[currentPoint].position) <= 0.5f)
                    {
                        yield return new WaitForSeconds(currentEventPatrol[0].timeToWaitBetweenEveryPoint);
                        currentPoint++;
                        if (currentPoint > currentEventPatrol[0].patrolPoints.Count - 1)
                        {
                            currentEventPatrol.Clear();
                        }
                    }
                    else
                    {
                        agent.SetDestination(currentEventPatrol[0].patrolPoints[currentPoint].position);
                        MoveTo(currentEventPatrol[0].patrolPoints[currentPoint], currentEventPatrol[0].patrolPoints.Count);
                        zone.RotateToTarget(currentEventPatrol[0].patrolPoints[currentPoint]);
                    }
                }

            }
            else if (!zone.Interaction)
            {
                agent.isStopped = false;

                if (patrolPoints.Count == 1 && !zone.PlayerSeen)
                {
                    zone.RotateToTarget(viewPoint);
                }

                if (zone.PlayerSeen && !patrolPointBeforePlayerSeen)
                {
                    InstantiateAPatrolPoint();
                }

                if (patrolPoints.Count > 1 && !zone.PlayerSeen && !patrolPointBeforePlayerSeen)
                {
                    RotateToTarget(patrolPoints[currentPoint]);
                    agent.SetDestination(patrolPoints[currentPoint].position);
                    MoveTo(patrolPoints[currentPoint], patrolPoints.Count);
                }
                else if (patrolPointBeforePlayerSeen && !zone.PlayerSeen)
                {
                    RotateToTarget(patrolPointBeforePlayerSeen);
                    agent.SetDestination(patrolPointBeforePlayerSeen.position);
                    MoveTo(patrolPointBeforePlayerSeen, 1, true);
                }
                else if (zone.PlayerSeen)
                {
                    RotateToTarget(zone.Target);
                    agent.SetDestination(zone.Target.position);
                    MoveTo(zone.Target, 1);
                }
            }
            else
            {
                agent.isStopped = true;
                //Debug.Log("Waiting");
            }

            yield return null;
        }
    }
}
