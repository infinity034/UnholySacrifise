using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private Slot slotPrefabs;

    [SerializeField]
    private Transform slotParent;

    [SerializeField]
    private int slotAmount = 1;

    [SerializeField]
    private List<Slot> slots = new List<Slot>();

    private void Start()
    {
        SetSlot();
    }

    private void SetSlot()
    {
        for (int i = 0; i < slotAmount; i++)
        {
            Slot slot = Instantiate(slotPrefabs, transform.position, Quaternion.identity);
            slot.transform.SetParent(slotParent);
            RectTransform rectTransform = slot.GetComponent<RectTransform>();
            rectTransform.localScale = Vector3.one;
            slot.name = "Slot (" + i + ")";
            slots.Add(slot);
        }
    }

    public void AddNewItemToFirstSlot(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (!slot.CurrentItem)
            {
                slot.AddItemToSlot(item);
                return;
            }
        }

        Debug.Log("Inventory is full!");
    }
}
