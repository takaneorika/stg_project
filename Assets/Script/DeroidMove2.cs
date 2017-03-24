using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//回転ビット 回転演出

public class DeroidMove2 : MonoBehaviour {

    public float Z = 0;

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 10);

        while (true)
        {
            Z += 2;
            transform.eulerAngles = new Vector3(0, -90, Z);//回転
            return;
        }

    }
}