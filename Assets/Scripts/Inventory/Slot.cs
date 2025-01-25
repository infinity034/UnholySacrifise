using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Item currentItem;

    [SerializeField]
    private Image iconIm;

    [SerializeField]
    private TextMeshProUGUI amountTxt;

    [SerializeField]
    private int amount;

    public Item CurrentItem {  get { return currentItem; } }

    public void OnPointerClick(PointerEventData eventData)
    {
        UseItem();
    }

    public void AddItemToSlot(Item item, int add)
    {
        if (item)
        {
            currentItem = item;
            iconIm.sprite = item.SpriteIcon;

            amount += add;
            if(amount > 1)
            {
                amountTxt.text = amount.ToString();
            }
            else
            {
                amountTxt.text = "";
            }
        }
    }

    private void RemoveItemToSlot()
    {
        if (amount == 1)
        {
            amount = 0;
            amountTxt.text = "";
            currentItem = null;
        }
        else
        {
            amount--;
            amountTxt.text = amount.ToString();
        }
    }

    public void UseItem()
    {
        if (currentItem)
        {
            currentItem.OnUse();
            RemoveItemToSlot();
        }
    }
}
