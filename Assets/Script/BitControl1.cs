using UnityEngine;
using System.Collections;

public class BitControl1 : MonoBehaviour {
   
    public GameObject EnemyBullet1;
    public GameObject EnemyBullet2;
    public GameObject EnemyBullet3;
    public GameObject EnemyBullet4;
    public GameObject EnemyBullet5;
    float intervalTime;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Enemy_Base").GetComponent<EnemyBaseControl>().D2flag == true)
        {
            Destroy(this.gameObject);
        }

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 0.3f)
        {
            intervalTime = -1.0f;

            Instantiate(EnemyBullet1, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);

            Instantiate(EnemyBullet2, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);

            Instantiate(EnemyBullet3, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);


            Instantiate(EnemyBullet4, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);

            Instantiate(EnemyBullet5, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);
        }
    }
}
