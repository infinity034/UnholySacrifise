using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Patrol
{
    [SerializeField]
    protected float timeBeforeRePet = 5f;

    [SerializeField]
    protected bool isPetting;

    [SerializeField]
    protected GameObject fishLocated;

    protected override void Start()
    {
        base.Start();
        StartCoroutine(Interaction());
    }

    protected IEnumerator Interaction()
    {
        while (this.gameObject.activeSelf)
        {
            if (zone.Interactable)
            {
                if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed() && !isPetting)
                {
                    Pet();
                }
            }

            yield return null;
        }
    }

    protected override IEnumerator PatrolMovement()
    {
        InstantiateAPatrolPoint(true);
        while (this.gameObject.activeSelf)
        {
            if (patrolPoints.Count == 1 && !zone.PlayerSeen && !fishLocated)
            {
                zone.RotateToTarget(viewPoint);
            }

            if (fishLocated)
            {
                agent.isStopped = false;
                agent.SetDestination(fishLocated.transform.position);
                zone.RotateToTarget(fishLocated.transform);
            }
            else if (patrolPoints.Count > 1)
            {
                agent.isStopped = false;
                agent.SetDestination(patrolPoints[currentPoint].position);
                MoveTo(patrolPoints[currentPoint]);
            }
            else
            {
                agent.isStopped = true;
                Debug.Log("Waiting");
            }

            yield return null;
        }
    }

    protected void Pet()
    {
        isPetting = true;
        StartCoroutine(PetInteraction(timeBeforeRePet));
    }

    protected IEnumerator PetInteraction(float delay)
    {
        ImpactBar.Instance.SetImpactBar(10, true);
        yield return new WaitForSeconds(delay);
        isPetting = false;
    }

    public void RunToFish(GameObject go)
    {
        fishLocated = go;
    }
}
