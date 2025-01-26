using System.Collections;
using UnityEngine;

public class MovableFurniture : Furniture
{
    [SerializeField]
    private GameObject[] point;

    [SerializeField]
    private bool open, moving;

    [SerializeField]
    private NPC npcInteraction;

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed() && !moving)
            {
                Use();
            }
        }
    }

    private IEnumerator MoveLibrary()
    {
        do
        {
            if (open)
            {
                transform.position = Vector3.MoveTowards(transform.position, point[1].transform.position, 0.8f * Time.deltaTime);
                if (Vector3.Distance(transform.position, point[1].transform.position) < 0.001f)
                {
                    moving = false;
                    if (npcInteraction)
                    {
                        npcInteraction.Zone.Interaction = false;
                    }
                }
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, point[0].transform.position, 0.8f * Time.deltaTime);
                if (Vector3.Distance(transform.position, point[0].transform.position) < 0.001f)
                {
                    moving = false;
                    if (npcInteraction)
                    {
                        npcInteraction.Zone.Interaction = false;
                    }
                }
            }

            yield return new WaitForSeconds(0.001f);
        } while (moving);
        Debug.Log("Stop Moving");
    }

    public void Use(NPC npc = null)
    {
        if (!moving)
        {
            // Can Check If The NPC Has the Key, If Not Activatate NavMesh Obstacle
            npcInteraction = npc;
            open = !open;
            moving = true;
            StartCoroutine(MoveLibrary());
        }
    }
}
