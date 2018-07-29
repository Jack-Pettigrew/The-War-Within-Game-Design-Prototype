using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCameraController : MonoBehaviour {

    public float sensitivity = 5.0f, smoothing = 2.0f;
    Vector2 mouseMove, mouseSmooth;

    // Get the player object so it moves with mouse movement (parent)
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));         // Get Mouse Inputs (Vector2 md)
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));      // Scale md by new Vector2(X, Y) - includes sensitivity + smooting in Vector2 md 
        mouseSmooth.x = Mathf.Lerp(mouseSmooth.x, md.x, 1f / smoothing);                            // Lerp mouseSmooth by Mouse Input data (md) .x
        mouseSmooth.y = Mathf.Lerp(mouseSmooth.y, md.y, 1f / smoothing);                            // ^ .y
        mouseMove += mouseSmooth;                                                                   // Add mouseSmooth to mouseMove

        // Mouse Movement
        transform.localRotation = Quaternion.AngleAxis(-mouseMove.y, Vector3.right);                // Moves Camera by Y axis, around the X axis (vector3.right)
        player.transform.localRotation = Quaternion.AngleAxis(mouseMove.x, player.transform.up);    // Moves Player objects by X axis, around the Y axis (player.transform.up)
    }
}