using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattlefieldLevelLoad : MonoBehaviour {

    public string levelToLoad;
    public string levelToRemove;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        if (!SceneManager.GetSceneByName(levelToLoad).isLoaded)
            SceneManager.LoadScene(levelToLoad, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(levelToRemove);
    }
}
