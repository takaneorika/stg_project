using UnityEngine;
using System.Collections;

//ビット1回転タイプB

public class BitMove2 : MonoBehaviour
{

    public float Z = 0;

    void Update()
    {


        while (true)
        {
            Z -= 2;
            transform.eulerAngles = new Vector3(0, 0, Z);
            return;
        }
    }
}
