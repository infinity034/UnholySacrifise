using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public enum Alignement { Good, Bad, Both}
public class NPC : MonoBehaviour
{
    [SerializeField]
    protected Alignement alignement;

    [SerializeField]
    protected Transform body, viewPoint;

    [SerializeField]
    protected FieldView fieldView;

    [SerializeField]
    protected Zone zone;

    [SerializeField]
    protected NavMeshAgent agent;

    [SerializeField]
    protected List<Item> itemInventory;

    [SerializeField]
    protected List<Item> itemNeed;

    [SerializeField]
    protected int StealPoints;
    //Talk
    [SerializeField] GameObject interactionMenu;
    [SerializeField] GameObject activeText;
    [SerializeField] GameObject activeName;
    [SerializeField] GameObject activeImg;
    [SerializeField] Sprite npc;
    [SerializeField] string name;
    [SerializeField] string[] Dialogue;
    

   //Audio
    public AudioSource talk;
    public AudioSource steal;
    //
    public Transform Body {  get { return body; } }
    public FieldView FieldView { get { return fieldView; } }
    public Zone Zone { get { return zone; } }
    public NavMeshAgent Agent { get { return agent; } }

    protected virtual void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        activeImg.GetComponent<Image>().sprite= npc;
    }

    protected void RotateToTarget(Transform target, float speed = 1000f)
    {
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        zone.RotationView(targetRotation, speed);
    }

    protected void StealNPC()
    {
        if (itemInventory.Count >= 1)
        {
            int rd = Random.Range(0, itemInventory.Count);
            steal.Play();
            if(Inventory.Instance.AddNewItemToFirstSlot(itemInventory[rd], 1))
            {
                itemInventory.RemoveAt(rd);
                ImpactBar.Instance.ActionPoints(5, false);
                
            }
        }
    }

    public bool AllItemNeed()
    {
        int count = 0; 

        foreach(Item item in itemNeed)
        {
            foreach(Item i in itemInventory)
            {
                if(i == item)
                {
                    count++;
                }
            }
        }

        return count >= itemNeed.Count;
    }

    protected void SpeakToNPC()
    {
        talk.Play();
        interactionMenu.SetActive(true);
        Debug.Log("Speak");
    }
}
