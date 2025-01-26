using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : Patrol
{
    protected override void Start()
    {
        base.Start();
        StartCoroutine(Interaction());
    }

    protected IEnumerator Interaction()
    {
        while (this.gameObject.activeSelf)
        {
            if (zone.PlayerSeen && zone.Interactable)
            {
                if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed())
                {
                    SpeakToNPC();
                }
            }
            else if(!zone.PlayerSeen && zone.Interactable) 
            {
                if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed())
                {
                    StealNPC();
                    yield return new WaitForSeconds(1f);
                }
            }

            yield return null;
        }
    }
}
