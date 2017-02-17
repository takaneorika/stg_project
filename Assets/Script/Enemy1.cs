using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

    public int scoreValue = 120;
    public int HP = 20;
    public int Dmg = 5;
    public GameObject Explosion;
    public float Z_Speed = 2;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, -1 * Z_Speed);
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
