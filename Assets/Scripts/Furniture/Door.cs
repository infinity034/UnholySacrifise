using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : Furniture
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Debug.Log("enter");
            collider2D.enabled = false;
        }
    }

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            
        }
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Debug.Log("exit");
            collider2D.enabled = true;
        }
    }
}
