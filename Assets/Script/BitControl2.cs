using UnityEngine;
using System.Collections;

//ビット射撃タイプ2

public class BitControl2 : MonoBehaviour
{
    public GameObject EnemyBullet6;
    float intervalTime;
    float Z = 0;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
            Quaternion quat = Quaternion.Euler(0, 180, 0);

            intervalTime += Time.deltaTime;
            if (intervalTime >= 0.3f)
            {
                intervalTime = 0.2f;
                Instantiate(EnemyBullet6, transform.position, transform.rotation);

            }
 
    }
}
