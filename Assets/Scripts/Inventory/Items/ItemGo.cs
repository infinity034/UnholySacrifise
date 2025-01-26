using UnityEngine;

public class ItemGo : Furniture
{
    [SerializeField]
    protected Item currentItem;

    [SerializeField]
    protected int amount = 1;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {

    }

    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (PlayerController.Instance.PlayerControls.Player.Interact.IsPressed())
            {
                if(Inventory.Instance.AddNewItemToFirstSlot(currentItem, amount))
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    protected override void OnTriggerExit2D(Collider2D collision)
    {

    }
}
