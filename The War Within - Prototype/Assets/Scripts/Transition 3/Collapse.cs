using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collapse : MonoBehaviour {

    public Transform wall, wall2, wall3, ceiling, window;
    public Transform[] fadePoints;
    public GameObject[] enemies;
    public float speed;
    public bool collapse = false;
    public string loadLevel;
    BoxCollider trigger;

	// Use this for initialization
	void Start () {
        trigger = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (collapse)
        {
            wall.position = Vector3.MoveTowards(wall.position, fadePoints[0].position, speed * Time.deltaTime);
            wall2.position = Vector3.MoveTowards(wall2.position, fadePoints[2].position, speed * Time.deltaTime);
            wall3.position = Vector3.MoveTowards(wall3.position, fadePoints[1].position, speed * Time.deltaTime);
            ceiling.position = Vector3.MoveTowards(ceiling.position, fadePoints[2].position, speed * Time.deltaTime);
            window.position = Vector3.MoveTowards(window.position, fadePoints[2].position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered");
            collapse = true;
            SceneManager.LoadScene(loadLevel, LoadSceneMode.Additive);
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].SetActive(true);
            }
            trigger.enabled = false;
        }
    }
}
