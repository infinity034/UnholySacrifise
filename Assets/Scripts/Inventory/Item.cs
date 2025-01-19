using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField]
    private Sprite spriteIcon;

    public Sprite SpriteIcon { get { return spriteIcon; } }

    public virtual void OnUse()
    {

    }
}
