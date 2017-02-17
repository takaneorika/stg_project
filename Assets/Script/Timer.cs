using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

    public float timer = 0;

    void Update()
    {
        timer += Time.deltaTime*0.5f;
        ScoreManager.score += (int)timer;
    }
}