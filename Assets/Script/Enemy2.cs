using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

    public int i;
    public int scoreValue = 260;
    public int HP = 40;
    public int Dmg = 5;
    public GameObject Explosion;
    public float Z_Speed = 1;
    public GameObject EnemyBullet;
    float intervalTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(0, 0, -1 * Z_Speed);
        

       

        Quaternion quat = Quaternion.Euler(0, 180, 0);

            intervalTime += Time.deltaTime;

            if (intervalTime >= 0.3f)
            {
                intervalTime = -2f;
                Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), quat);
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