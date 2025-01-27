using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
[SerializeField] private GameObject player;
[SerializeField] private GameObject hidingspot;
[SerializeField] private SpriteRenderer visual; 

private Collider2D hittingZone;
private SpriteRenderer playerSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
         playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
         hittingZone=player.gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D()
    {
       if(hittingZone==true)
       {
        Debug.Log("gotcha!");
        HidePlayer();
       }
        
    }
    public void HidePlayer()
    {
        visual.enabled=false;
    }

    public void OnTriggerExit2D()
    {
       if(hittingZone==true)
       {
        Debug.Log("Seeya!");
        ShowPlayer();
       }
    }

    void ShowPlayer()
    {
        visual.enabled=true;
    }

}
