using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour {

    public float end = 2f;
    public float lerpFloat = 0.5f;
    private Light pLight;

    void Start()
    {
        pLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update () {
        // Increase Light intensity by Mathf.Lerp(Start Intensity, Finish Intensity, Amount of Time * decreaser timer over seconds)
        pLight.intensity = Mathf.Lerp(pLight.intensity, end, lerpFloat * Time.deltaTime);
	}
}
