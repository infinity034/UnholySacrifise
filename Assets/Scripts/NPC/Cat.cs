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
    public AudioSource purr;
    public AudioSource miaou;
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
                miaou.Play();

            }
            else if (patrolPoints.Count > 1)
            {
                agent.isStopped = false;
                agent.SetDestination(patrolPoints[currentPoint].position);
                MoveTo(patrolPoints[currentPoint], patrolPoints.Count);
            }
            else
            {
                agent.isStopped = true;
               // Debug.Log("Waiting");
            }

            yield return null;
        }
    }

    protected void Pet()
    {
        isPetting = true;
        StartCoroutine(PetInteraction(timeBeforeRePet));
        purr.Play();
    }

    protected IEnumerator PetInteraction(float delay)
    {
        ImpactBar.Instance.ActionPoints(10, true);
        yield return new WaitForSeconds(delay);
        isPetting = false;
    }

    public void RunToFish(GameObject go)
    {
        fishLocated = go;
    }
}
