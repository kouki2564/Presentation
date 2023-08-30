using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMove : MonoBehaviour
{
    Vector3 scale;

    Vector3 startPosTop;
    Vector3 startPosMiddle;
    Vector3 startPosUnder;
    
    Vector3 endPos;

    Vector3 move;

    int randnum;


    void Start()
    {
        scale = new Vector3(0.5f, 0.5f, 0.5f);
        transform.localScale= scale;
        randnum = Random.Range(1, 4);
        startPosUnder = new Vector3(1.295f, 0.1f, 0);
        startPosMiddle = new Vector3(1.295f, 0.53f, 0);
        startPosTop = new Vector3(1.295f, 0.96f, 0);
        endPos = new Vector3(-1.8f, 0, 0);
        move = new Vector3(-0.03f, 0, 0);
        switch(randnum)
        {
            case 1:
                transform.position = startPosTop;
                break;
            case 2:
                transform.position = startPosMiddle;
                break;
            case 3:
                transform.position = startPosUnder;
                break;
            default: break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < endPos.x) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(move);
    }
}
