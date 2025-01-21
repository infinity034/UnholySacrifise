using UnityEngine;

public class Library : Furniture
{
    [SerializeField]
    private GameObject[] point;

    [SerializeField]
    private bool enter ,open, moving;

    private void Update()
    {
        if (!enter && !moving) return;
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
    }


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
}
