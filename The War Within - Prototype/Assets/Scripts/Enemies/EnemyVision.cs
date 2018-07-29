using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyVision : MonoBehaviour
{

    public Stealth stealthScript;
    public GameObject spottedText, introText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && stealthScript.visible == true)
        {
            stealthScript.spotted = true;
            introText.SetActive(false);
            spottedText.SetActive(true);
        }
    }
}
