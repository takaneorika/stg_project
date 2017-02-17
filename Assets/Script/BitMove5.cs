using UnityEngine;
using System.Collections;

public class BitMove5 : MonoBehaviour {

    public float Z = 0;
    public int scoreValue = 1000;
    public int HP = 200;
    public int Dmg = 5;
    public GameObject Explosion;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("Enemy_Base").GetComponent<EnemyBaseControl>().D2flag == true)
        {
            Destroy(this.gameObject);
        }

        while (true)
        {
            Z -= 2;
            transform.eulerAngles = new Vector3(0, 0, Z);
            
            return;
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

