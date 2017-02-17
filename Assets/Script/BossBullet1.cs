using UnityEngine;
using System.Collections;

public class BossBullet1 : MonoBehaviour {

    public float Z = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        while (true)
        {
            Z += 2;
            transform.eulerAngles = new Vector3(0, 0, Z);
            return;
        }
    }
}
