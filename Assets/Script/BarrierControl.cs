using UnityEngine;
using System.Collections;

public class BarrierControl : MonoBehaviour {

    public int BarrierPower = 30;
    public GameObject Explosion;
    public GameObject Barrier;
    public int BarrierValue = 1;
    public int BarrierPlus = 5;

    void OnTriggerEnter(Collider hit)
    {

        if (hit.tag == "Item")
        {
            BarrierPower += 5;
            BarrierManager.score += BarrierPlus;
        }

        if (hit.tag == "EnemyBullet")
        {
            BarrierPower -= 1;
            
            if (BarrierPower > 0)
            {
                Instantiate(Barrier, new Vector3(transform.position.x, transform.position.y,
                    transform.position.z), Quaternion.identity);
                BarrierManager.score -= BarrierValue;
            }
        }
        

        if (BarrierPower == 0)
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            GameObject.Find("Main Camera").GetComponent<GameControl>().gameFlag = false;
            GameObject.Find("Enemy_Base").GetComponent<EnemyBaseControl>().gameflag = false;
            Destroy(this.gameObject);
        }

    }
    
}
