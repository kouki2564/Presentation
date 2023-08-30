using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    Vector3 StartPos;
    Vector3 EndPos;
    Vector3 Move;
    public float endposX;

    
    void Start()
    {
        StartPos = new Vector3(1.235f, -0.06f,0);
        EndPos = new Vector3(-3.24f, 0, 0);
        Move = new Vector3(-0.03f, 0, 0);
    }

    void FixedUpdate()
    {
        transform.position += Move;
    }

    void Update()
    {
        if(transform.position.x < EndPos.x)
        {
            transform.position = StartPos;
        }
    }
}
