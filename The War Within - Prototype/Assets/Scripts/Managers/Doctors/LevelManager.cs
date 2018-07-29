using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public string level1;

    void Awake()
    {
        if (!SceneManager.GetSceneByName(level1).isLoaded)
        {
            SceneManager.LoadScene(level1, LoadSceneMode.Additive);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
}
