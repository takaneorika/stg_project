using UnityEngine;
using System.Collections;

public class BitBullet4 : MonoBehaviour
{
    float bulletSpeed = 2;

  
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, 140);


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
