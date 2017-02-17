using UnityEngine;
using System.Collections;

public class StarfighterControl : MonoBehaviour
{
   
   public float z_Speed = -3;
   public float y_Speed = 2;
   
    public GameObject Prefab;
    public GameObject Explosion;
    float intervalTime;
    public bool flag;
    
    // Use this for initialization
    void Start()
    {
        intervalTime = 0;
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        intervalTime += Time.deltaTime;

        float vertical = Input.GetAxisRaw("Vertical");

        float horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown("o"))
        {
            if (GetComponent<BoxCollider>().enabled == true)
            {
                GetComponent<BoxCollider>().enabled = false;
            }
            else
            {
                GetComponent<BoxCollider>().enabled = true;
            }
        }

        if (Input.GetKeyDown("d"))
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            GameObject.Find("Main Camera").GetComponent<GameControl>().gameFlag = false;
            Destroy(this.gameObject);
        }

             

        if (Input.GetKeyDown("x"))
        {
            if (flag == true)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }            
        }

        if (Input.GetKey("left shift"))
        {
            z_Speed = -2;
            y_Speed = 1;
        }

        if (Input.GetKeyUp("left shift"))
        {
            z_Speed = -3;
            y_Speed = 2;
        }

        if (Input.GetKey("right shift"))
        {
            z_Speed = -2;
            y_Speed = 1;
        }

        if (Input.GetKeyUp("right shift"))
        {
            z_Speed = -3;
            y_Speed = 2;
        }

         if (Input.GetKey("up"))
         {
             transform.Translate(vertical * 0, y_Speed,0);
         }
         if (Input.GetKey("down"))
         {
             transform.Translate(vertical * 0, -y_Speed,0);
         }
         if (Input.GetKey("left"))
         {
             transform.Translate(horizontal * 0, 0, z_Speed);
         }
         if (Input.GetKey("right"))
         {
             transform.Translate(horizontal * 0, 0, -z_Speed);
         }

                
        if (Input.GetKey("z"))
        {
            if (intervalTime >= 0.1f)
            {
                if (flag == true)
                {
                    intervalTime = 0.0f;
                    Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y + 3,
                        transform.position.z), Quaternion.identity);

                    Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y,
                        transform.position.z), Quaternion.identity);

                    Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y - 3,
                        transform.position.z), Quaternion.identity);
                }

                if (flag == false)
                {
                    intervalTime = -0.05f;
                    Instantiate(Prefab, new Vector3(transform.position.x+2, transform.position.y + 2,
                        transform.position.z), Quaternion.Euler(0, 0, 20));

                    Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y,
                        transform.position.z), Quaternion.identity);

                    Instantiate(Prefab, new Vector3(transform.position.x+2, transform.position.y - 2,
                        transform.position.z), Quaternion.Euler(0, 0, -20));

                    Instantiate(Prefab, new Vector3(transform.position.x+3, transform.position.y - 5,
                        transform.position.z), Quaternion.Euler(0, 0, -20));

                    Instantiate(Prefab, new Vector3(transform.position.x+3, transform.position.y + 5,
                        transform.position.z), Quaternion.Euler(0, 0, 20));


                }
            }
            
        }

        
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(transform.position.x, -270, 270);

        pos.y = Mathf.Clamp(transform.position.y, -150, 150);

        transform.position = pos;

       
    }

    void OnTriggerEnter(Collider coll)
    {
        

        if ((coll.gameObject.tag == "Enemy"|| coll.gameObject.tag == "Boss"))
        {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y,
                transform.position.z), Quaternion.identity);
            GameObject.Find("Main Camera").GetComponent<GameControl>().gameFlag = false;
            GameObject.Find("Enemy_Base").GetComponent<EnemyBaseControl>().gameflag = false;
            Destroy(this.gameObject);
            
        }
    }

   

}

