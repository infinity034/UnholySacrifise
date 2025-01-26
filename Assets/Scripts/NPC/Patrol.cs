using System.Collections;
using System.Collections.Generic;
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
            if (patrolPoints.Count == 1 && !zone.PlayerSeen)
            {
                zone.RotateToTarget(viewPoint);
            }

            if (patrolPoints.Count > 1)
            {
                agent.SetDestination(patrolPoints[currentPoint].position);
                MoveTo(patrolPoints[currentPoint]);
            }

            yield return null;
        }
    }

    protected virtual void MoveTo(Transform point, bool returnToPoint = false)
    {
        if (Vector3.Distance(body.position, point.position) <= 0.5f)
        {
            if (returnToPoint)
            {
                
            }
            else
            {
                NewPoint(patrolLoop);
            }
        }
    }

    protected void NewPoint(bool loop)
    {
        if(loop)
        {
            if (currentPoint < patrolPoints.Count -1)
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
                if (currentPoint < patrolPoints.Count - 1)
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
