using UnityEngine;
using System.Collections;

//EnemyMove_5

public class Enemy5 : MonoBehaviour {

    public float Xpoint = 0;
    public float Z_Speed = 2;
    public GameObject EnemyBullet2;
    public GameObject EnemyBullet3;
    float intervalTime;

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 7);

        if (transform.position.x >= Xpoint)//position.X = 100 まで移動
        {
            transform.Translate(0, 0, -1 * Z_Speed);
        }
        if (transform.position.x <= Xpoint)//position.X = 100 に着いたら攻撃開始
        {
            Quaternion quat = Quaternion.Euler(0, 180, 0);

            intervalTime += Time.deltaTime;
            if (intervalTime >= 0.3f)
            {
                intervalTime = -0.5f;

                Instantiate(EnemyBullet2, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);

                Instantiate(EnemyBullet3, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);
            }
        }
    }
}