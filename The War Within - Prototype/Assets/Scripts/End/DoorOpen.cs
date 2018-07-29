using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour {

    public Transform door, wife;
    public Camera playerCam;
    public FPSMoveController fpsMove;
    public FPSCameraController fpsCam;
    public float angle, speed, waitTime;
    public string loadLevel;
    bool end;
    BoxCollider bc;

	// Use this for initialization
	void Start () {
        bc = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (end)
            playerCam.transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            door.Rotate(Vector3.up, angle);
            playerCam.transform.LookAt(wife);
            bc.enabled = false;
            fpsCam.enabled = false;
            fpsMove.enabled = false;
            end = true;
            Invoke("LoadLevel", waitTime);
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(loadLevel);
    }
}
