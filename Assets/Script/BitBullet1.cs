using UnityEngine;
using System.Collections;

public class BitBullet1 : MonoBehaviour
{
    float bulletSpeed = 2;

    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed, 0);
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
