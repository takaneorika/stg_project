using UnityEngine;
using System.Collections;

public class TorisetuControl : MonoBehaviour {

    public AudioClip audioClip1;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }



    void OnGUI()
    {
       
        if (GUI.Button(new Rect(800, 180, 50, 50), "X"))
        {

        }

        if (GUI.Button(new Rect(1000, 175, 200, 60), "ショット切り替え"))
        {

        }

        if (GUI.Button(new Rect(800, 280, 50, 50), "↑"))
        {

        }

        if (GUI.Button(new Rect(800, 340, 50, 50), "↓"))
        {

        }

        if (GUI.Button(new Rect(740, 340, 50, 50), "←"))
        {

        }

        if (GUI.Button(new Rect(860, 340, 50, 50), "→"))
        {

        }

        if (GUI.Button(new Rect(1000, 320, 200, 60), "移動"))
        {

        }

        if (GUI.Button(new Rect(800, 440, 50, 50), "Z"))
        {

        }

        if (GUI.Button(new Rect(1000, 433, 200, 60), "ショット"))
        {

        }
               
        if (GUI.Button(new Rect(720, 540, 200, 50), "移動キー + SHIFT"))
        {

        }
        
        if (GUI.Button(new Rect(1000, 532, 200, 60), "低速移動"))
        {

        }

        if (GUI.Button(new Rect(800, 640, 50, 50), "D"))
        {

        }

        if (GUI.Button(new Rect(1000, 632, 200, 60), "自爆"))
        {

        }

        if (GUI.Button(new Rect(860, 740, 200, 50), "タイトルへ"))
        {
            audioSource.Play();
            Application.LoadLevel("Title");
        }

    }
}