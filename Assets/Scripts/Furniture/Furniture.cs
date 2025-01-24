using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furniture : MonoBehaviour
{
    [SerializeField]
    protected Collider2D collider2D;

    protected virtual void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    protected virtual void OnTriggerStay2D(Collider2D collision)
    {

    }

    protected virtual void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
