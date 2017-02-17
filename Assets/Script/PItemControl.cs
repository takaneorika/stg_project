using UnityEngine;
using System.Collections;

public class PItemControl : MonoBehaviour
{
    float ItemSpeed = 0.5f;
   

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x >= -60)
        {
            transform.Translate(-ItemSpeed, 0, 0);
        }
        if(transform.position.x <= -60)
        {           
                transform.Translate(-ItemSpeed, 0, 0);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
