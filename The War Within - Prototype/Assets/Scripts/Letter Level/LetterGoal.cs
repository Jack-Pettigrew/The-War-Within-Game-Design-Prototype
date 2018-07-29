using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterGoal : MonoBehaviour {

    public string levelToLoad;
    public int activateNumber = 12;
    private int lightCounter = 0;
    public GameObject[] spotLights;

    void OnTriggerEnter(Collider other)
    {
        lightCounter = 0;

        if (other.gameObject.tag == "Player")
        {
            for(int i = 0; i < spotLights.Length; i++)
            {
                if (spotLights[i].activeSelf == false)
                {
                    lightCounter++;
                }
            }

            if(lightCounter >= activateNumber)
            {
                LoadLevel();
            }
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
