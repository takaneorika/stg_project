using UnityEngine;
using System.Collections;

//EnemyMove_2

public class Enemy2 : MonoBehaviour {

    public float Z_Speed = 1;
    public GameObject EnemyBullet;
    float intervalTime;

    // Update is called once per frame
    void Update()
    {
            //移動
            transform.Translate(0, 0, -1 * Z_Speed);
             

        Quaternion quat = Quaternion.Euler(0, 180, 0);

            intervalTime += Time.deltaTime;

            if (intervalTime >= 0.3f)
            {
                intervalTime = -2f;//射撃間隔
                Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);
            }
        
      }
}