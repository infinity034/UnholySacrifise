using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField]
    protected Sprite spriteIcon;

    public Sprite SpriteIcon { get { return spriteIcon; } }

    public virtual void OnUse()
    {

    }
}
