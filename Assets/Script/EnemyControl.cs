using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour
{
    public int scoreValue = 1000;
    public GameObject EnemyBullet1;
    public GameObject EnemyBullet2;
    public GameObject EnemyBullet3;
    public GameObject Explosion;
    float Z_Speed = 0.7f;
    float intervalTime;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

       // transform.Translate(0, 0, 1 * Z_Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 0.3f)
        {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet1, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);
      
            intervalTime = 0.0f;
            Instantiate(EnemyBullet2, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);

            intervalTime = 0.0f;
            Instantiate(EnemyBullet3, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), quat);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            ScoreManager.score += scoreValue;
            Destroy(this.gameObject);
           
        }

    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}

