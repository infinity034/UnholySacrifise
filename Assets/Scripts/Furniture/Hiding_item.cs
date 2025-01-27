using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
[SerializeField] private GameObject Player;
[SerializeField] private GameObject Hidingspot;
private 
private SpriteRenderer playerSpriteRenderer

    // Start is called before the first frame update
    void Start()
    {
         playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Colision){
        Colision=Hidingspot.GetComponent<Collider2D>();
        Player.localPosition=Hidingspot.localPosition;
    }
    public void HidePlayer()
    {
        if (playerSpriteRenderer != null)
        {
           playerSpriteRenderer.enabled = false; // Set to invisible
        }
    }

    public void ShowObject()
    {
        if (playerSpriteRenderer != null)
        {
            playerSpriteRenderer.enabled = true; // Set visible
        }
    }
}
