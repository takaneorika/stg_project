using UnityEngine;
using System.Collections;

public class BitMove1 : MonoBehaviour {

    public int scoreValue = 1000;
    public int HP = 200;
    public int Dmg = 5;
    public GameObject Explosion;
    public float X_Speed = 2;
    

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 10);
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

            if (HP <= 50)
            {
                transform.Translate(0, 0, 1 * X_Speed);
            }
        }
    }
    
}
