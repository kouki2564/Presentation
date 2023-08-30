using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageJenerator : MonoBehaviour
{
    int Timer;
    int RandNum;
    int RandNum2;
    int RandNum3;

    public GameObject block1_1;
    public GameObject block1_2;
    public GameObject block1_3;
    public GameObject block1_4;

    public GameObject block2_1;
    public GameObject block2_2;
    public GameObject block2_3;

    public GameObject block3_1;
    public GameObject block3_2;
    public GameObject block3_3;

    void Start()
    {
        Timer = 0;
        RandNum = 0;
        RandNum2 = 0;
        RandNum3 = 0;
    }

    void Update()
    {
        if(Timer == 10)
        {

        }
    }

    private void FixedUpdate()
    {
        Timer++;
    }
}
