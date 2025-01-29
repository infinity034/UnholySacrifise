using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource source;
 

    // Update is called once per frame
    void Awake()
    {
        source=source.GetComponent<AudioSource>();
         

    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
       Debug.Log("hearYa");
       source.Play();
        
    }
}
