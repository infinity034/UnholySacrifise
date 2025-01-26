using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Furniture
{
    bool isSkipping;

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed() && !isSkipping)
            {
                isSkipping = true;
                StartCoroutine(SkipADay());
            }
        }
    }

    IEnumerator SkipADay()
    {
        DayClock.Instance.SkipADay();
        yield return new WaitForSeconds(1f);
        isSkipping = false;
    }
}
