using UnityEngine;
using System.Collections;

public class TitleControl : MonoBehaviour
{
    public AudioClip audioClip1;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(860, 600, 200, 50), "スタート"))
        {
            audioSource.Play();
            Application.LoadLevel("game");
        }

        if (GUI.Button(new Rect(860, 700, 200, 50), "操作説明"))
        {
            audioSource.Play();
            Application.LoadLevel("Torisetu");
        }

    }
}