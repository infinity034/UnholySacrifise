using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Patrol
{
    [SerializeField]
    protected float timeBeforeRePet = 5f;

    [SerializeField]
    protected bool isPetting;

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
}
