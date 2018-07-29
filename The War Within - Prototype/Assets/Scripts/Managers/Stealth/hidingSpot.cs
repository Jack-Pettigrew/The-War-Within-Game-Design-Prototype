using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidingSpot : MonoBehaviour {

    public Stealth stealthScript;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            stealthScript.visible = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            stealthScript.visible = true;
        }
    }
}
