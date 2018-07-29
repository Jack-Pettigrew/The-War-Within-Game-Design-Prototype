using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AppleManager : MonoBehaviour {

    public FPSMoveController fpsController;
    public FPSCameraController fpsCamera;
    public Image image;
    public AudioSource grenade, ambience;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trigger")
        {
            fpsCamera.enabled = false;
            fpsController.enabled = false;
            image.enabled = true;
            grenade.Play();
            ambience.Stop();

            Invoke("LoadLevel", 5.0f);
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene("StealthLevel1");
    }
}
