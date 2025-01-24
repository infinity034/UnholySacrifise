using System.Collections;
using UnityEngine;

public class Library : Furniture
{
    [SerializeField]
    private GameObject[] point;

    [SerializeField]
    private bool enter ,open, moving;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enter = true;
        }
    }

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.PlayerControls.Player.Action.IsPressed() && !moving)
            {
                open = !open;
                moving = true;
                StartCoroutine(MoveLibrary());
            }
        }
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enter = false;
        }
    }

    private IEnumerator MoveLibrary()
    {
        do
        {
            if (open)
            {
                transform.position = Vector3.MoveTowards(transform.position, point[1].transform.position, 1 * Time.deltaTime);
                if (Vector3.Distance(transform.position, point[1].transform.position) < 0.001f)
                {
                    moving = false;
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point[0].transform.position, 1 * Time.deltaTime);
                if (Vector3.Distance(transform.position, point[0].transform.position) < 0.001f)
                {
                    moving = false;
                }
            }

            yield return new WaitForSeconds(0.001f);
        } while (moving);
        Debug.Log("Stop Moving");
    }
}
