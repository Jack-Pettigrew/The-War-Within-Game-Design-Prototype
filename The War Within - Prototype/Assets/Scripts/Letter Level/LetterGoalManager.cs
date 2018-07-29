using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterGoalManager : MonoBehaviour
{
    public PostManMove pmove;
    public GameObject postLight, envolope;
    public PointLight veterenLight;
    public Transform envolopeGoal;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            pmove.enabled = false;
            postLight.SetActive(false);
            envolope.transform.position =  envolopeGoal.position;
            veterenLight.enabled = true;
        }
    }
}
