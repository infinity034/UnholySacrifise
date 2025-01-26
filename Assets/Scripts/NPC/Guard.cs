using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Guard : Patrol
{
    [SerializeField]
    private Transform patrolPointBeforePlayerSeen;

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
            if(!zone.Interaction)
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
