using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : Patrol
{
    

    protected override void Start()
    {
        base.Start();
    }

    protected override IEnumerator PatrolMovement()
    {
        InstantiateAPatrolPoint(true);
        while (this.gameObject.activeSelf)
        {
            if(patrolPoints.Count == 1 && !fieldView.PlayerSeen)
            {
                fieldView.RotateToTarget(viewPoint);
            }

            if (fieldView.PlayerSeen && !patrolPointBeforePlayerSeen)
            {
                InstantiateAPatrolPoint();
            }

            if (patrolPoints.Count > 1 && !fieldView.PlayerSeen && !patrolPointBeforePlayerSeen)
            {
                MoveTo(patrolPoints[currentPoint]);
            }
            else if (patrolPointBeforePlayerSeen && !fieldView.PlayerSeen)
            {
                MoveTo(patrolPointBeforePlayerSeen, true);
            }
            else if (fieldView.PlayerSeen)
            {
                MoveTo(fieldView.Target);
            }

            yield return null;
        }
    }
}
