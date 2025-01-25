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

    protected override void MoveTo(Transform point, bool returnToPoint = false)
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
                NewPoint(patrolLoop);
            }
        }
    }

    protected override IEnumerator PatrolMovement()
    {
        InstantiateAPatrolPoint(true);
        while (this.gameObject.activeSelf)
        {
            if(!fieldView.Interaction)
            {
                agent.isStopped = false;

                if (patrolPoints.Count == 1 && !fieldView.PlayerSeen)
                {
                    fieldView.RotateToTarget(viewPoint);
                }

                if (fieldView.PlayerSeen && !patrolPointBeforePlayerSeen)
                {
                    InstantiateAPatrolPoint();
                }

                if (patrolPoints.Count > 1 && !fieldView.PlayerSeen && !patrolPointBeforePlayerSeen)
                {
                    //Debug.Log("1.1");
                    RotateToTarget(patrolPoints[currentPoint]);
                    agent.SetDestination(patrolPoints[currentPoint].position);
                    MoveTo(patrolPoints[currentPoint]);
                }
                else if (patrolPointBeforePlayerSeen && !fieldView.PlayerSeen)
                {
                    //Debug.Log("1.2");
                    RotateToTarget(patrolPointBeforePlayerSeen);
                    agent.SetDestination(patrolPointBeforePlayerSeen.position);
                    MoveTo(patrolPointBeforePlayerSeen, true);
                }
                else if (fieldView.PlayerSeen)
                {
                    //Debug.Log("1.3");
                    RotateToTarget(fieldView.Target);
                    agent.SetDestination(fieldView.Target.position);
                    MoveTo(fieldView.Target);
                }
            }
            else
            {
                agent.isStopped = true;
                Debug.Log("Waiting");
            }

            yield return null;
        }
    }
}
