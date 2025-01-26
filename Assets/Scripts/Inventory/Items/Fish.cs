using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : ItemGo
{
    protected override void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cat"))
        {
            Debug.Log("Cat Found");
            Cat cat = collision.gameObject.GetComponentInParent<Cat>();
            cat.RunToFish(this.gameObject);
        }
    }
}
