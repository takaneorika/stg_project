using UnityEngine;
using System.Collections;

public class EnemyBaseControl : MonoBehaviour
{

    public GameObject zako_A;//神風
    public GameObject zako_B;//普通
    public GameObject zako_C;//帰宅部
    public GameObject zako_D;//帰宅部
    public GameObject zako_E;//Destroy(this.gameObject, 7);
    public GameObject zako_F;//Destroy(this.gameObject, 7);
    public GameObject Bit1;//Destroy(this.gameObject, 10);
    public GameObject Bit2;//Destroy(this.gameObject, 10);
    public GameObject Bit3;//Destroy(this.gameObject, 10);
    public GameObject Bit4;//御供
    public GameObject Bit5;//御供
    public GameObject Bit6;//御供
    public GameObject Boss;//Boss
    public GameObject Gate;//マーカー    
    public float timer = 0;
    public int i;
    public float y;
    public bool gameflag;
    public bool Dflag;
    public bool D2flag;

    void Start()
    {
        gameflag = true;
        Dflag = false;
        D2flag = false;
        StartCoroutine(Example());
    }

    void Update()
    {

    }

    IEnumerator Example()
    {

        Quaternion quat = Quaternion.Euler(0, 90, 0);

        //wave1
        if (gameflag == true)
        {
            yield return new WaitForSeconds(2);
            for (i = 1; i <= 6; i++)
            {
                yield return new WaitForSeconds(0.2f);
                Instantiate(zako_C, new Vector3(transform.position.x + 270, transform.position.y + 50,
                        transform.position.z), quat);

                Instantiate(zako_D, new Vector3(transform.position.x + 270, transform.position.y - 50,
                        transform.position.z), quat);
            }
        }

        //wave2
        if (gameflag == true)
        {
            yield return new WaitForSeconds(2);

            Instantiate(zako_E, new Vector3(transform.position.x + 270, transform.position.y + 50,
                        transform.position.z), quat);

            Instantiate(zako_E, new Vector3(transform.position.x + 270, transform.position.y - 50,
                        transform.position.z), quat);

            Instantiate(zako_F, new Vector3(transform.position.x + 270, transform.position.y,
                        transform.position.z), quat);

        }
        //wave3
        if (gameflag == true)
        {
            yield return new WaitForSeconds(3);

            Instantiate(Gate, new Vector3(transform.position.x + 140, transform.position.y + 50,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 140, transform.position.y - 50,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.5f);

            Instantiate(Bit1, new Vector3(transform.position.x + 140, transform.position.y + 50,
                       transform.position.z), quat);

            Instantiate(Bit3, new Vector3(transform.position.x + 140, transform.position.y - 50,
                       transform.position.z), quat);
        }

        //wave4
        if (gameflag == true)
        {
            yield return new WaitForSeconds(2);
            for (i = 1; i <= 6; i++)
            {
                yield return new WaitForSeconds(0.2f);
                Instantiate(zako_C, new Vector3(transform.position.x + 270, transform.position.y,
                        transform.position.z), quat);

                Instantiate(zako_C, new Vector3(transform.position.x + 270, transform.position.y + 160,
                        transform.position.z), quat);

                Instantiate(zako_D, new Vector3(transform.position.x + 270, transform.position.y - 160,
                        transform.position.z), quat);

                yield return new WaitForSeconds(0.2f);
                Instantiate(zako_D, new Vector3(transform.position.x + 270, transform.position.y,
                        transform.position.z), quat);
            }
        }

        //wave5
        if (gameflag == true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
               transform.position.z), quat);
            y = 20;
            for (i = 1; i <= 4; i++)
            {
                y += 20;
                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
                   transform.position.z), quat);

                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y + y,
                   transform.position.z), quat);

                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y - y,
                           transform.position.z), quat);

                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y + 30 + y,
                   transform.position.z), quat);

                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y - 30 - y,
                           transform.position.z), quat);
            }
        }

        //wave6
        if (gameflag == true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
               transform.position.z), quat);
            y = 20;
            for (i = 1; i <= 6; i++)
            {
                y += 20;

                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
                   transform.position.z), quat);

                Instantiate(zako_D, new Vector3(transform.position.x + 270, transform.position.y + y,
                   transform.position.z), quat);

                Instantiate(zako_C, new Vector3(transform.position.x + 270, transform.position.y - y,
                           transform.position.z), quat);
            }
            Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y + 130,
                   transform.position.z), quat);

            Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y - 130,
                       transform.position.z), quat);
        }

        //wave7
        if (gameflag == true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y,
                       transform.position.z), quat);
            yield return new WaitForSeconds(0.5f);
            Instantiate(Bit2, new Vector3(transform.position.x + 160, transform.position.y,
                       transform.position.z), quat);

            yield return new WaitForSeconds(3f);

            Instantiate(zako_E, new Vector3(transform.position.x + 270, transform.position.y + 50,
                        transform.position.z), quat);

            Instantiate(zako_E, new Vector3(transform.position.x + 270, transform.position.y - 50,
                        transform.position.z), quat);

            Instantiate(zako_F, new Vector3(transform.position.x + 270, transform.position.y,
                        transform.position.z), quat);
        }

        //wave8
        if (gameflag == true)
        {
            yield return new WaitForSeconds(3);

            Instantiate(Gate, new Vector3(transform.position.x + 170, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 170, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x - 170, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x - 170, transform.position.y - 80,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.5f);

            Instantiate(Gate, new Vector3(transform.position.x + 170, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 170, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x - 170, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x - 170, transform.position.y - 80,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.5f);

            Instantiate(Bit3, new Vector3(transform.position.x + 170, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Bit1, new Vector3(transform.position.x + 170, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Bit1, new Vector3(transform.position.x - 170, transform.position.y - 80,
                       transform.position.z), Quaternion.Euler(0, 0, 180));

            Instantiate(Bit3, new Vector3(transform.position.x - 170, transform.position.y + 80,
                       transform.position.z), Quaternion.Euler(0, 0, 180));

        }

        //wave9
        if (gameflag == true)
        {
            yield return new WaitForSeconds(10);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.5f);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.5f);

            Instantiate(Bit2, new Vector3(transform.position.x + 120, transform.position.y + 80,
                       transform.position.z), quat);

            Instantiate(Bit2, new Vector3(transform.position.x + 120, transform.position.y - 80,
                       transform.position.z), quat);

            Instantiate(Bit2, new Vector3(transform.position.x + 160, transform.position.y,
                       transform.position.z), quat);
        }

        //wave10
        if (gameflag == true)
        {
            yield return new WaitForSeconds(10);
            for (i = 1; i <= 4; i++)
            {
                y += 20;
                y *= -1;
                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
                   transform.position.z), quat);

                Instantiate(zako_D, new Vector3(transform.position.x + 270, transform.position.y + y,
                   transform.position.z), quat);

                Instantiate(zako_C, new Vector3(transform.position.x + 270, transform.position.y - y,
                           transform.position.z), quat);
            }

        }

        //wave11
        if (gameflag == true)
        {
            yield return new WaitForSeconds(4);
            y = 35;
            for (i = 1; i <= 2; i++)
            {

                y *= -1;
                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y + y,
                   transform.position.z), quat);
                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y - y,
                           transform.position.z), quat);
            }
            for (i = 1; i <= 5; i++)
            {
                yield return new WaitForSeconds(0.2f);
                Instantiate(zako_A, new Vector3(transform.position.x + 270, transform.position.y,
                   transform.position.z), quat);
            }

            Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y,
               transform.position.z), quat);

            y = 0;
            for (i = 1; i <= 5; i++)
            {
                y += 20;
                yield return new WaitForSeconds(0.5f);
                Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y + y,
                   transform.position.z), quat);

                Instantiate(zako_B, new Vector3(transform.position.x + 270, transform.position.y - y,
                           transform.position.z), quat);
            }

        }

        //Boss wave
        if (gameflag == true)
        {

            yield return new WaitForSeconds(6f);

            D2flag = true;

            Instantiate(Boss, new Vector3(transform.position.x + 400, transform.position.y + 15,
               transform.position.z), Quaternion.Euler(0, -90, 0));
        }

        //Boss Bit
        if (gameflag == true)
        {
            yield return new WaitForSeconds(6);

            D2flag = false;

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y + 90,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y - 90,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y - 90,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 120, transform.position.y + 90,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Bit6, new Vector3(transform.position.x + 120, transform.position.y + 90,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            Instantiate(Bit6, new Vector3(transform.position.x + 120, transform.position.y - 90,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            yield return new WaitForSeconds(2);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y + 120,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y - 120,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y - 120,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 160, transform.position.y + 120,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Bit6, new Vector3(transform.position.x + 160, transform.position.y + 120,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            Instantiate(Bit6, new Vector3(transform.position.x + 160, transform.position.y - 120,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            yield return new WaitForSeconds(2);

            Instantiate(Gate, new Vector3(transform.position.x + 80, transform.position.y + 60,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 80, transform.position.y - 60,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Gate, new Vector3(transform.position.x + 80, transform.position.y - 60,
                       transform.position.z), quat);

            Instantiate(Gate, new Vector3(transform.position.x + 80, transform.position.y + 60,
                       transform.position.z), quat);

            yield return new WaitForSeconds(0.2f);

            Instantiate(Bit6, new Vector3(transform.position.x + 80, transform.position.y + 60,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            Instantiate(Bit6, new Vector3(transform.position.x + 80, transform.position.y - 60,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            yield return new WaitForSeconds(5);
            Instantiate(Gate, new Vector3(transform.position.x + 200, transform.position.y - 120,
                       transform.position.z), Quaternion.Euler(0, 90, 30));

            Instantiate(Gate, new Vector3(transform.position.x + 200, transform.position.y + 120,
                       transform.position.z), Quaternion.Euler(0, 90, -30));

            yield return new WaitForSeconds(0.2f);
            Instantiate(Gate, new Vector3(transform.position.x + 200, transform.position.y - 120,
                       transform.position.z), Quaternion.Euler(0, 90, 0));

            Instantiate(Gate, new Vector3(transform.position.x + 200, transform.position.y + 120,
                       transform.position.z), Quaternion.Euler(0, 90, 0));

            yield return new WaitForSeconds(0.2f);
            Instantiate(Bit5, new Vector3(transform.position.x + 200, transform.position.y - 120,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

            Instantiate(Bit4, new Vector3(transform.position.x + 200, transform.position.y + 120,
                       transform.position.z), Quaternion.Euler(0, -90, 0));

        }
    }
}

