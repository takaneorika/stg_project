using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{
    float bulletSpeed = 5;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed, 0,0 );
    }
    void OnTriggerEnter(Collider hit)
    {
        if ((hit.gameObject.tag == "Enemy" || hit.gameObject.tag == "Boss"))
        {
            Destroy(this.gameObject);
        }
    }
}
