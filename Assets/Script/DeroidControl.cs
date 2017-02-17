using UnityEngine;
using System.Collections;

public class DeroidControl : MonoBehaviour {

    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    float intervalTime;
    float Z = 0;

    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 0.3f)
        {
            intervalTime = -1f;
            Instantiate(Bullet1, new Vector3(transform.position.x, transform.position.y,
                   transform.position.z), quat);

            Instantiate(Bullet2, new Vector3(transform.position.x, transform.position.y,
                   transform.position.z), quat);

            Instantiate(Bullet3, new Vector3(transform.position.x, transform.position.y,
                   transform.position.z), quat);

        }

    }
}
