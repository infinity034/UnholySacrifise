using UnityEngine;

public class Door : Furniture
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Debug.Log("enter");
            GetComponent<Collider2D>().enabled = false;
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
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
