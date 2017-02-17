using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour
{
    public GameObject GameOverSet;
    public bool gameFlag;
    public AudioClip audioClip1;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        gameFlag = true;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnGUI()
    {

        if (gameFlag == false)
        {
            if (GUI.Button(new Rect(860, 415, 200, 50), "タイトルへ"))
            {
                audioSource.Play();
                Application.LoadLevel("Title");
            }
        }
    }
}