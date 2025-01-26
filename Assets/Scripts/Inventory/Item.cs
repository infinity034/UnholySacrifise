using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Test", menuName = "Item")]
public class Item : ScriptableObject
{
    [SerializeField]
    protected GameObject itemGo;

    [SerializeField]
    protected Sprite spriteIcon;

    [SerializeField]
    protected bool canBeDrop;

    public Sprite SpriteIcon { get { return spriteIcon; } }
    public bool CanBeDrop { get { return canBeDrop; } }

    public virtual void OnUse(Transform parent = null)
    {
        
    }
}
