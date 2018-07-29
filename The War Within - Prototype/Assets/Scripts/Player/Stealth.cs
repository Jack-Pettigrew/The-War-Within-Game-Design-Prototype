using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stealth : MonoBehaviour {

    // Player Spotted?
    public bool visible = false;
    public bool spotted = false;
    public float levelRestartTime = 5f;
    private PlayerMovement pMove;

    void Awake()
    {
        visible = true;
        pMove = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update () {
		if(!visible)
        {

        }

        if (spotted)
        {
            Invoke("RestartLevel", 3f);
            pMove.enabled = false;
        }
	}

    void RestartLevel ()
    {
        SceneManager.LoadScene("StealthLevel1"); // Load same level
    }
}
