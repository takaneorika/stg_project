using UnityEngine;
using System.Collections;

public class BossMove : MonoBehaviour {
    public int scoreValue = 24560;
    public int HP = 5000;
    public int Dmg = 5;
    public GameObject Explosion;
    public float Z_Speed = 1;
    public float Z = 0;
    float intervalTime;
    public GameObject EnemyBullet1;//バレット1
    public GameObject EnemyBullet2;//バレット2
    public GameObject EnemyBullet3;//バレット3
    public GameObject EnemyBullet4;//バレット4
    public GameObject EnemyBullet5;//バレット5
   
    // Use this for initialization
    void Start()
    {
        
    }

    
    //ダメージ判定
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "PlayerBullet")
        {
            HP = HP - Dmg;
        }

        //撃破後クリアフラグの切り替え
        if (HP == 0)
        {

            ScoreManager.score += scoreValue;
            GameObject.Find("music_Box").GetComponent<ClearFlag>().Clearflag = true;
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);        
            Destroy(this.gameObject);
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        //登場
        if (transform.position.x >= 140)
        {
            transform.Translate(0, 0, 1 * Z_Speed);
        }
        Quaternion quat = Quaternion.Euler(0, 180, 0);

       
        intervalTime += Time.deltaTime;

        if (HP > 0)
        {
            if (transform.position.x <= 139)
            {
                if (intervalTime >= 0.3f)
                {
                    if (HP > 1000)
                    {
                        intervalTime = -0.8f;
                        Instantiate(EnemyBullet1, new Vector3(transform.position.x - 80, transform.position.y - 15,
                        transform.position.z), quat);

                        Instantiate(EnemyBullet1, new Vector3(transform.position.x - 50, transform.position.y - 5,
                        transform.position.z), quat);

                        Instantiate(EnemyBullet1, new Vector3(transform.position.x - 50, transform.position.y - 25,
                        transform.position.z), quat);
                    }
                }
            }

            //攻撃パターン変化
            if (HP < 2500)
            {
                if (intervalTime >= 0.3f)
                {
                    intervalTime = -0.5f;
                    Instantiate(EnemyBullet5, new Vector3(transform.position.x - 50, transform.position.y +5,
                    transform.position.z), quat);

                    Instantiate(EnemyBullet2, new Vector3(transform.position.x - 50, transform.position.y -15,
                    transform.position.z), quat);

                    Instantiate(EnemyBullet3, new Vector3(transform.position.x - 50, transform.position.y -15,
                    transform.position.z), quat);

                    Instantiate(EnemyBullet4, new Vector3(transform.position.x - 50, transform.position.y -15,
                    transform.position.z), quat);

                    Instantiate(EnemyBullet5, new Vector3(transform.position.x - 50, transform.position.y - 35,
                    transform.position.z), quat);
                }
            }
        }

    }
}