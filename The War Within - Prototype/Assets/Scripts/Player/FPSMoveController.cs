using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMoveController : MonoBehaviour {

    public float speed = 10f;

    // Use this for initialization
    void Start()
    {
        // Keep Cursor centered
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float translate = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float translateSideways = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        // Keyboard Movement
        transform.Translate(translateSideways, 0, translate);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}