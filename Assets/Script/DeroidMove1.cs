using UnityEngine;
using System.Collections;

//回転ビット(自然消滅タイプ) 回転演出

public class DeroidMove1 : MonoBehaviour {

    public float Z = 0;
    
    // Update is called once per frame
    void Update()
    {
        while (true)
        {
            Z += 2;
            transform.eulerAngles = new Vector3(0, -90, Z);//回転
            return;
        }

    }
}