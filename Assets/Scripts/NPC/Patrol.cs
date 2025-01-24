using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Patrol : NPC
{
    [SerializeField]
    private Transform[] patrolPoints;

    [SerializeField]
    private int currentPoint;

    [SerializeField]
    private bool patrolLoop, patrolReturn;

    private void Start()
    {
        StartCoroutine(PatrolMovement());
    }

    private IEnumerator PatrolMovement()
    {
        while(this.gameObject.activeSelf)
        {
            if(patrolPoints.Length > 0)
            {
                MoveTo(patrolPoints[currentPoint]);
            }
            yield return null;
        }
    }

    private void MoveTo(Transform point)
    {
        if (Vector3.Distance(body.position, point.position) > 0.001f)
        {
            body.position = Vector3.MoveTowards(body.position, point.position, 1f * Time.deltaTime);
            RotateToTarget(point);
        }
        else
        {
            NewPoint(patrolLoop);
        }
    }

    private void NewPoint(bool loop)
    {
        if(loop)
        {
            if (currentPoint < patrolPoints.Length -1)
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
                if (currentPoint < patrolPoints.Length - 1)
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

    private void RotateToTarget(Transform target)
    {
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        fieldView.DirectionView.rotation = Quaternion.RotateTowards(fieldView.DirectionView.rotation, targetRotation, 1000 * Time.deltaTime);
    }
}
