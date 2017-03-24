using UnityEngine;
using System.Collections;

//EnemyMove_1

public class Enemy1 : MonoBehaviour {

    public float Z_Speed = 2;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, -1 * Z_Speed);
    }
}
