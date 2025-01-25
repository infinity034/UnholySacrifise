using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : Patrol
{
    protected override void Start()
    {
        base.Start();
    }

    protected IEnumerator Interaction()
    {
        while (this.gameObject.activeSelf)
        {
            if (fieldView.PlayerSeen && fieldView.Interactable)
            {
                // Begin a Choice
            }
            else if(!fieldView.PlayerSeen && fieldView.Interactable) 
            {
                // Can Steal
            }

            yield return null;
        }
    }
}
