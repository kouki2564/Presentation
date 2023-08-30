using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenelatorUnder : MonoBehaviour
{
    public GameObject b1_1;
    public GameObject b1_2;
    public GameObject b1_3;
    public GameObject b1_4;

    public GameObject b2_1;
    public GameObject b2_2;
    public GameObject b2_3;

    public GameObject b3_1;
    public GameObject b3_2;
    public GameObject b3_3;

    int timer;
    int randnum;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        randnum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer == 20)
        {
            randnum = Random.Range(2, 11);

            switch (randnum) 
            {
                case 1: Instantiate(b1_1);
                    break;
                case 2: Instantiate(b1_2);
                    break;
                case 3: Instantiate(b1_3);
                    break;

                case 4: Instantiate(b1_4);
                    break;
                case 5: Instantiate(b2_1);
                    break;
                case 6: Instantiate(b2_2);
                    break;
                case 7: Instantiate(b2_3);
                    break;

                case 8: Instantiate(b3_1);
                    break;
                case 9: Instantiate(b3_2);
                    break;
                case 10: Instantiate(b3_3);
                    break;

                default: break;
            }

            timer= 0;
        }
    }

    private void FixedUpdate()
    {
        timer++;
    }
}
