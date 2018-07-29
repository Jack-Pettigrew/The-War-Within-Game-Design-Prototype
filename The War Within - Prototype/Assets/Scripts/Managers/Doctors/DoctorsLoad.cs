using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoctorsLoad : MonoBehaviour {

    public string levelToLoad;
    public Text first, second, third;
    public RawImage overlay;
    public float intervalOne, intervalTwo, intervalThree;
    bool run = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        if (run)
        {
            run = false;
            FirstText();
            Invoke("SecondText", intervalOne);
            Invoke("ThirdText", intervalTwo);
            Invoke("LoadLevel", intervalThree);
        }
    }

    void FirstText()
    {
        first.enabled = true;
    }

    void SecondText()
    {
        first.enabled = false;
        second.enabled = true;
    }

    void ThirdText()
    {
        second.enabled = false;
        overlay.enabled = true;
        third.enabled = true;
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
