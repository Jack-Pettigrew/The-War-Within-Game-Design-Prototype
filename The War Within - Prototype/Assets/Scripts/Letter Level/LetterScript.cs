using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour {

    public GameObject spotLight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (spotLight.activeSelf == true)
            {
                spotLight.SetActive(false);
            }
            else
            {
                spotLight.SetActive(true);
            }
        }
   }
}
