//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Fading : MonoBehaviour
//{

//    public Texture2D fadeOutTexture;    // texture that will fade
//    public float fadeSpeed = 0.8f;

//    private int drawDepth = -1000;      // Tells unity to draw the texture on top of everything (draw last)
//    private float alpha = 1.0f;
//    private int fadeDir = -1;           // Controls whether fade is IN or OUT (fade in (-1) or fade out (1))

//    void OnGUI()                        // Unity's method of GUI
//    {
//        alpha += fadeDir * fadeSpeed * Time.deltaTime;      // fade of alpha with fadeDir by fadeSpeed over time (realtime)
//        alpha = Mathf.Clamp01(alpha);                       // clamp between 0 and 1

//        // Setting Colour and Alpha of Texture
//        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
//        GUI.depth = drawDepth;                                                              // send texture to the back of render queue
//        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);       // draw texture to screen size
//    }

//    public float BeginFade(int direction)
//    {
//        fadeDir = direction;
//        return (fadeSpeed);
//    }

//    void OnLevelWasLoaded()
//    {
//        BeginFade(-1);
//    }
//}
