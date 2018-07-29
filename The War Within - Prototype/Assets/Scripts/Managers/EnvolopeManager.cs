using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvolopeManager : MonoBehaviour
{

    public float rotationSpeed = 5f;
    public float floatSpeed = 5f;
    public float offset = 1f;

    Vector3 start;
    Vector3 end;

    // Use this for initialization
    void Start()
    {
        this.start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

        // Reset end Vector3
        end = start;
        // 'Bounce'
        end.y += Mathf.Sin(Time.fixedTime * floatSpeed) * offset;
        // Move
        transform.position = end;
    }
}
