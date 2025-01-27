using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Patrol : NPC
{
    [SerializeField]
    protected Transform patrolPoint, patrolPointParent;

    [SerializeField]
    protected List<Transform> patrolPoints;

    [SerializeField]
    protected int currentPoint;

    [SerializeField]
    protected bool patrolLoop, patrolReturn;

    [SerializeField]
    protected List<EventPatrol> eventPatrols;

    [SerializeField]
    protected List<EventPatrol> currentEventPatrol;

    protected override void Start()
    {
        base.Start();
        StartCoroutine(PatrolMovement());
    }

    protected virtual void InstantiateAPatrolPoint(bool start = false)
    {
        Transform go = Instantiate(patrolPoint, body.position, Quaternion.identity);
        go.transform.SetParent(patrolPointParent.transform);
        if(start)
        {
            patrolPoints.Insert(0, go);
        }
    }

    protected virtual IEnumerator PatrolMovement()
    {
        InstantiateAPatrolPoint(true);
        while (this.gameObject.activeSelf)
        {
            if(eventPatrols.Count > 0)
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
            else
            {
                if (patrolPoints.Count == 1 && !zone.PlayerSeen)
                {
                    zone.RotateToTarget(viewPoint);
                }

                if (patrolPoints.Count > 1)
                {
                    agent.isStopped = false;
                    agent.SetDestination(patrolPoints[currentPoint].position);
                    MoveTo(patrolPoints[currentPoint], patrolPoints.Count);
                }
                else
                {
                    agent.isStopped = true;
                    Debug.Log("Waiting");
                }
            }

            yield return null;
        }
    }

    protected virtual void MoveTo(Transform point, int count, bool returnToPoint = false)
    {
        zone.RotateToTarget(point);
        if (Vector3.Distance(body.position, point.position) <= 0.5f)
        {
            if (returnToPoint)
            {
                
            }
            else
            {
                NewPoint(patrolLoop, count);
            }
        }
    }

    protected void NewPoint(bool loop, int count)
    {
        if(loop)
        {
            if (currentPoint < count -1)
            {
                currentPoint++;
            }
            else
            {
                currentPoint = 0;
            }
        }
        else
        {
            if(patrolReturn)
            {
                if (currentPoint < count - 1)
                {
                    currentPoint++;
                }
                else
                {
                    currentPoint--;
                    patrolReturn = !patrolReturn;
                }
            }
            else
            {
                if (currentPoint > 0)
                {
                    currentPoint--;
                }
                else
                {
                    currentPoint++;
                    patrolReturn = !patrolReturn;
                }
            }
        }
    }
}
