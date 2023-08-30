using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YusyaMove : MonoBehaviour
{
    Vector3 Move;
    Vector2 JumpForce;
    Vector3 SetPos;
    Vector3 ReturnMove;
    Vector3 PushPos;

    Rigidbody2D rbody;

    public bool ReturnFlag;
    bool JumpFlag;
    public float JumpPow;

    int timer;

    void Start()
    {

        timer = 0;
        SetPos = new Vector3(-0.7f, 0.27f, 0);
        Move = new Vector3(0, 0.005f, 0);
        ReturnMove = new Vector3(0.15f, 0, 0);
        PushPos = new Vector3(-0.05f, 0, 0);
        ReturnFlag = false;
        JumpPow = 200;
        JumpForce = new Vector2(0, JumpPow);
        JumpFlag = false;
        rbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // 上下運動
        
        // 左側に行った後の位置復帰
        if (transform.position.x < SetPos.x)
        {
            transform.position += ReturnMove;
        }
        //if (!ReturnFlag) transform.position += PushPos;

        //if (jumpflag)
        //{
        //    timer = 0;
        //    rbody.addforce(jumpforce);
        //    if (timer == 30)
        //    {

        //        jumpflag=false;
        //    }
        //}
        

    }

    //void Jump()
    //{
    //    Debug.Log(ReturnFlag);
    //    if (ReturnFlag) return;
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Debug.Log("space");
    //        rbody.AddForce(JumpForce);
    //        ReturnFlag = true;
    //    }
    //}
        
    void Update()
        {
        Debug.Log(ReturnFlag);
        if ((Input.GetKeyDown(KeyCode.Space))&& (!ReturnFlag))
        {
            Debug.Log("space");
            rbody.AddForce(JumpForce);
            ReturnFlag = true;
        }
            // ジャンプ
            //if (Input.GetKey(KeyCode.A))
            //{
            //    JumpFlag = true;
            //    Debug.Log("space");

            //    //if (transform.position.y < 0.3f) JumpFlag = false;
            //}
        }
        
    private void OnTriggerEnter2D(Collider2D other)                 // 当たり判定を察知
        
    {
            
        if (ReturnFlag)
            
        {
                
            if (other.gameObject.name == "road")
                
            {

                ReturnFlag = false;
                
            }
                
            if (other.gameObject.name == "road(1)")
                
            {

                ReturnFlag = false;
                
            }
            
        }
        
    }
    
}