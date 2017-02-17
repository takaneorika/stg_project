using UnityEngine;
using System.Collections;

public class Enemy3 : MonoBehaviour {

    public float X = 2;
    public int scoreValue = 120;
    public int HP = 20;
    public int Dmg = 5;
    public GameObject Explosion;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * 2);
        while (true)
        {

            if (X < 30 && transform.position.x <= 0)
            {
                X -= 2;
                transform.eulerAngles = new Vector3(X, 90,X);
            }
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

