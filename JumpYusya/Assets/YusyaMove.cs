using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YusyaMove : MonoBehaviour
{
    Vector3 Move;
    Vector3 SetPos;
    Vector3 ReturnMove;

    Rigidbody2D rbody;

    public int MaxJumpCount = 2;
    private int jumpCount = 0;

    public bool ReturnFlag;
    //public float JumpPow;
    Vector3 JumpPow = new Vector3(0f, 7.5f, 0);

    int timer;

    void Start()
    {

        timer = 0;
        SetPos = new Vector3(-1.4f, 0.255f, 0);
        Move = new Vector3(0, 0.005f, 0);
        ReturnMove = new Vector3(10f, 0, 0);
        ReturnFlag = false;
    //    JumpPow = 400;
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 上下運動
        
        // 左側に行った後の位置復帰
        if (transform.position.x < SetPos.x)
        {
            rbody.AddForce(ReturnMove);
        }
        if(transform.position.x >= SetPos.x)
        {
            rbody.velocity = new Vector2(0, rbody.velocity.y);
        }
        

    }
        
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)))
        {
            if (jumpCount < MaxJumpCount)
            {
                Debug.Log(jumpCount);

                rbody.velocity = Vector2.zero;

                rbody.AddForce(JumpPow, ForceMode2D.Impulse);
                jumpCount++;
            }            
        }
        if (transform.position.x < -3) transform.position = SetPos;
    }
        
    private void OnTriggerEnter2D(Collider2D other)                 // 当たり判定を察知
        
    {
        jumpCount = 0;
    }
    
}