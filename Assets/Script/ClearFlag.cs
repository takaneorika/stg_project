using UnityEngine;
using System.Collections;

public class ClearFlag : MonoBehaviour {

    public bool Clearflag;
    public AudioClip audioClip1;
    private AudioSource audioSource;
    internal static bool clearflag;



    // Use this for initialization
    void Start () {
        Clearflag = false;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }
	
	// Update is called once per frame
	void Update () {
        var clone = GameObject.FindGameObjectWithTag("Enemy");
        if (Clearflag == true)
        {
            Destroy(clone);
        }
    }

    void OnGUI()
    {

    if (Clearflag == true)
    {
            if (GUI.Button(new Rect(860, 300, 200, 50), "クリア"))
            {

                
            }
            if (GUI.Button(new Rect(860, 425, 200, 50), "タイトルへ"))
            {
                audioSource.Play();
                Application.LoadLevel("Title");
            }
        }
    }
}
