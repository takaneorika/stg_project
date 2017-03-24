using UnityEngine;
using System.Collections;

public class BitBullet6 : MonoBehaviour
{
    float bulletSpeed = 1;
   

    // Update is called once per frame
    void Update()
    {
            transform.Translate(bulletSpeed, 0, 0);            
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
   
}