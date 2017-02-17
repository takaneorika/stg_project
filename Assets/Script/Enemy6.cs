using UnityEngine;
using System.Collections;

public class Enemy6 : MonoBehaviour {


    public int scoreValue = 120;
    public int HP = 20;
    public int Dmg = 5;
    public GameObject Explosion;
    public float Z_Speed = 2;
    public GameObject EnemyBullet1;
    public GameObject EnemyBullet2;
    public GameObject EnemyBullet3;
    float intervalTime;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(this.gameObject, 7);

        if (transform.position.x >= 140)
        {
            transform.Translate(0, 0, -1 * Z_Speed);
        }
        if (transform.position.x <= 140)
        {
            Quaternion quat = Quaternion.Euler(0, 180, 0);

            intervalTime += Time.deltaTime;
            if (intervalTime >= 0.3f)
            {
                intervalTime = -0.5f;
               // Instantiate(EnemyBullet1, new Vector3(transform.position.x, transform.position.y,
                 //   transform.position.z), quat);

                Instantiate(EnemyBullet2, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);

                Instantiate(EnemyBullet3, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);
            }
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            HP = HP - Dmg;
        }

        if (HP == 0)
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            ScoreManager.score += scoreValue;
            Destroy(this.gameObject);
        }
    }
}