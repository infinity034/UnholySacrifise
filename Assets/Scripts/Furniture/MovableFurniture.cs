using System.Collections;
using UnityEngine;

public class MovableFurniture : Furniture
{
    [SerializeField]
    protected GameObject mainGo;

    [SerializeField]
    protected GameObject[] point;

    [SerializeField]
    protected bool open, moving;

    [SerializeField]
    protected NPC npcInteraction;

    public bool Open { get { return open; } }

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
                mainGo.transform.position = Vector3.MoveTowards(mainGo.transform.position, point[1].transform.position, 0.8f * Time.deltaTime);
                if (Vector3.Distance(mainGo.transform.position, point[1].transform.position) < 0.001f)
                {
                    moving = false;
                    if (npcInteraction)
                    {
                        npcInteraction.Agent.isStopped = false;
                        npcInteraction.Zone.Interaction = false;
                    }
                }
            }
            else
            {
                mainGo.transform.position = Vector3.MoveTowards(mainGo.transform.position, point[0].transform.position, 0.8f * Time.deltaTime);
                if (Vector3.Distance(mainGo.transform.position, point[0].transform.position) < 0.001f)
                {
                    moving = false;
                    if (npcInteraction)
                    {
                        npcInteraction.Agent.isStopped = false;
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
            Debug.Log("Use The Door");
            // Can Check If The NPC Has the Key, If Not Activatate NavMesh Obstacle
            if(npc != null)
            {
                npcInteraction = npc;
                npc.Agent.isStopped = true;
            }
            open = !open;
            moving = true;
            StartCoroutine(MoveLibrary());
        }
    }
}
