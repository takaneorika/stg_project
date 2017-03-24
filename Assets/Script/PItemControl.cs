using UnityEngine;
using System.Collections;

public class PItemControl : MonoBehaviour
{
    float ItemSpeed = 0.5f;
    public float X = 0;

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
       
        while (true)
        {
            X -= 2;
            transform.eulerAngles = new Vector3(X, 0, 0);
            return;
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
