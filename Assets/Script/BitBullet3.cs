using UnityEngine;
using System.Collections;

public class BitBullet3 : MonoBehaviour
{
    float bulletSpeed = 2;

 
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, -160);


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
