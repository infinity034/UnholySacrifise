using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Item currentItem;

    [SerializeField]
    private Image iconIm;

    public Item CurrentItem {  get { return currentItem; } }

    public void OnPointerClick(PointerEventData eventData)
    {
        UseItem();
    }

    public void AddItemToSlot(Item item)
    {
        if (item)
        {
            iconIm.sprite = item.SpriteIcon;
        }
    }

    public void UseItem()
    {
        if (currentItem)
        {
            currentItem.OnUse();
            currentItem = null;
        }
    }
}
