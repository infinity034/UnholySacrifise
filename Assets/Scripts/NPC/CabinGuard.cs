using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinGuard : Guard
{
    [SerializeField]
    ContactZone contactZone;

    [SerializeField]
    private Transform[] points;

    public bool isScanning, playerSeen;
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
                        if(currentPoint == 0)
                        {
                            isScanning = true;
                            StartCoroutine(ScanArea());
                            yield return new WaitForSeconds(currentEventPatrol[0].timeToWaitBetweenEveryPoint);
                            isScanning = false;
                            Debug.Log("Caugth : " + LibraryIsMoveOrPlayerIsMissing());
                            if (LibraryIsMoveOrPlayerIsMissing())
                            {
                                contactZone.TeleportPlayerAndPriestToForest();
                            }
                        }
                        currentPoint++;
                        if (currentPoint > currentEventPatrol[0].patrolPoints.Count - 1)
                        {
                            currentEventPatrol.Clear();
                        }
                    }
                    else if (!isScanning)
                    {
                        agent.SetDestination(currentEventPatrol[0].patrolPoints[currentPoint].position);
                        MoveTo(currentEventPatrol[0].patrolPoints[currentPoint], currentEventPatrol[0].patrolPoints.Count);
                        zone.RotateToTarget(currentEventPatrol[0].patrolPoints[currentPoint]);
                    }
                }

            }
            else if (!zone.Interaction && !isScanning)
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

    private IEnumerator ScanArea()
    {
        bool scanArea = true;
        int currentPoint = 0;
        int countdown = 0;
        while (scanArea)
        {
            countdown++;
            switch (currentPoint)
            {
                case 0:
                    if (countdown >= 900)
                    {
                        countdown = 0;
                        currentPoint++;
                    }
                    break;
                case 1:
                    if (countdown >= 1250)
                    {
                        countdown = 0;
                        currentPoint++;
                    }
                    break;
                case 2:
                    if (countdown >= 250)
                    {
                        countdown = 0;
                        scanArea = false;
                    }
                    break;
            }
            Debug.Log(countdown);
            RotateToTarget(points[currentPoint], 20f);
            yield return null;
        }
    }

    private bool LibraryIsMoveOrPlayerIsMissing()
    {
        if (Library.Instance.Open || !playerSeen)
        {
            return true;
        }
        return false;
    }
}
