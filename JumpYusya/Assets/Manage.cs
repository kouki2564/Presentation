using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour
{
    public GameObject yusya;
    public Score score;
    public GameObject gameover;
    public GameObject tytle;

    int s = 0; 

    int timer;

    bool istytle;
    bool isgameover;

    void Start()
    {
        Time.timeScale = 0;
        istytle = true;
        isgameover = false;
        tytle.SetActive(true);
        gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if((yusya.transform.position.x < -3)&&(!istytle)&&(!isgameover))
        {
            isgameover= true;
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
        if ((istytle)&&(Input.GetMouseButtonDown(0)))
        {
            istytle = false;
            tytle.SetActive(false);
            Time.timeScale = 1;
        }
        if((isgameover) && (Input.GetMouseButtonDown(0)))
        {
            isgameover = false;
            istytle= true;
            gameover.SetActive(false);
            tytle.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void FixedUpdate()
    {
        
    }
}
