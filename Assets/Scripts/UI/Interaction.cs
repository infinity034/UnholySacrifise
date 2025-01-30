using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] GameObject menuTalk;
   [SerializeField] GameObject menuInteraction;
    // Start is called before the first frame update
    void Start()
    {
        menuInteraction.SetActive(false);
        menuTalk.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    //Est appeller quand le boutton pause est appuyer
    public void Talk()
    {
        menuInteraction.SetActive(false);
        menuTalk.SetActive(true);
        Time.timeScale=0;
    }

    public void Action()
    {
        //something happen

        
    }
    //
    public void Leave()
    {
        menuInteraction.SetActive(false);
        Time.timeScale=1;        
    }
}
