using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarrierManager : MonoBehaviour {

    public static int score;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 10;
    }
    void Update()
    {
        text.text = "シールド残量: " + score;
    }
}