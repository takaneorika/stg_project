using UnityEngine;
using System.Collections;

//EnemyMove_3

public class Enemy3 : MonoBehaviour {

    public float X = 2;
    public float turn = 0;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * 2);

        while (true)
        {

            if (X < 30 && transform.position.x <= turn)
            {
                X -= 2;
                transform.eulerAngles = new Vector3(X, 90,X);
            }
            return;
        }
    }
}

