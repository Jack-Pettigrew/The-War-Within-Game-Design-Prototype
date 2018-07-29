using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LetterDialogue : MonoBehaviour {

    public string levelToLoad;
    public Text first, second, third, fourth, fifth, sixth;
    public RawImage overlay;
    public float intervalOne, intervalTwo, intervalThree, intervalFour, intervalFive, intervalSix;
    bool run = true;
    public Animator overlayAlpha;
    public AudioSource music;

	// Use this for initialization
	void Start () {
        overlayAlpha.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {
        if (run)
        {
            run = false;
            FirstText();
            Invoke("SecondText", intervalOne);
            Invoke("ThirdText", intervalTwo);
            Invoke("FourthText", intervalThree);
            Invoke("FifthText", intervalFour);
            Invoke("SixthText", intervalFive);
            Invoke("LoadLevel", intervalSix);
        }
    }

    void FirstText()
    {
        first.enabled = true;
        music.Play();
    }

    void SecondText()
    {
        first.enabled = false;
        overlayAlpha.enabled = true;
        second.enabled = true;
    }

    void ThirdText()
    {
        second.enabled = false;
        third.enabled = true;
    }

    void FourthText()
    {
        third.enabled = false;
        fourth.enabled = true;
    }

    void FifthText()
    {
        fourth.enabled = false;
        fifth.enabled = true;
    }

    void SixthText()
    {
        fifth.enabled = false;
        sixth.enabled = true;
    }

    void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
