using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵HP,撃破　共通スクリプト

public class HPSystem : MonoBehaviour
{

    public int scoreValue = 0;　 //撃破後加算ポイント
    public int HP = 0;           //敵体力
    public int Dmg = 5;          //敵被ダメージ
    public GameObject Explosion; //撃破演出

    void OnTriggerEnter(Collider coll)
    {
        //ダメージ判定
        if (coll.gameObject.tag == "PlayerBullet")
        {
            HP = HP - Dmg;
        }

        //撃破判定
        if (HP == 0)
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            ScoreManager.score += scoreValue;
            Destroy(this.gameObject);
        }
    }
}