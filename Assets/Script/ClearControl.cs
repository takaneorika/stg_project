using UnityEngine;
using System.Collections;

public class ClearControl : MonoBehaviour {

    public AudioClip audioClip1;
    private AudioSource audioSource;
    


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }

    void OnGUI()
    {


        if (GUI.Button(new Rect(690, 400, 200, 50), "タイトルへ"))
        {
            audioSource.Play();
            Application.LoadLevel("Title");
        }
    }
}
