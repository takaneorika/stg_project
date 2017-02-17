using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {

    float bulletSpeed = 2;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed, 0,0);
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
