using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    public Transform Body {  get { return body; } }
    public FieldView FieldView { get { return fieldView; } }
    public Zone Zone { get { return zone; } }

    protected virtual void Start()
    {
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    protected void RotateToTarget(Transform target)
    {
        float angle = Mathf.Atan2(target.position.y - body.position.y, target.position.x - body.position.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        zone.RotationView(targetRotation);
    }

    protected void StealNPC()
    {
        if (itemInventory.Count >= 1)
        {
            int rd = Random.Range(0, itemInventory.Count);

            if(Inventory.Instance.AddNewItemToFirstSlot(itemInventory[rd], 1))
            {
                itemInventory.RemoveAt(rd);
            }
        }
    }

    protected void SpeakToNPC()
    {

    }
}
