using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifiertrigger : MonoBehaviour {
    public string eventName = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AmbienceSound.AmbienceManager.ActivateEvent(eventName);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AmbienceSound.AmbienceManager.DeactivateEvent(eventName);
        }
    }

}
