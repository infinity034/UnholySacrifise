using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
[SerializeField] private GameObject player;
[SerializeField] private GameObject hidingspot;
[SerializeField] private SpriteRenderer playerVisual; 
[SerializeField] private GameObject[] switchImg;

private Collider2D hittingZone;


    // Start is called before the first frame update
    void Start()
    {
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
        playerVisual.enabled=false;
        switchImg[0].GetComponent<SpriteRenderer>().enabled=false;
        switchImg[1].GetComponent<SpriteRenderer>().enabled=true;
       
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
        playerVisual.enabled=true;
       switchImg[1].GetComponent<SpriteRenderer>().enabled=false;
        switchImg[0].GetComponent<SpriteRenderer>().enabled=true;
    }

}
