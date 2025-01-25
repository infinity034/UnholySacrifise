using System.Collections;
using UnityEngine;

public class MovableFurniture : Furniture
{
    [SerializeField]
    private GameObject[] point;

    [SerializeField]
    private bool open, moving;

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed() && !moving)
            {
                open = !open;
                moving = true;
                StartCoroutine(MoveLibrary());
            }
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
