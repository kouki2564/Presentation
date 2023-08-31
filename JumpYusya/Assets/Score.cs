using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public double scoreNum = 0;
    int timer = 0;

    void Start()
    {
        score.text = "000000";
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreNum < 10) score.SetText("00000{0}",(int)scoreNum);
        else if(scoreNum < 100) score.SetText("0000{0}", (int)scoreNum);
        else if (scoreNum < 1000) score.SetText("000{0}", (int)scoreNum);
        else if (scoreNum < 10000) score.SetText("00{0}", (int)scoreNum);
        else if (scoreNum < 100000) score.SetText("0{0}", (int)scoreNum);
        else score.SetText("", (int)scoreNum);
    }

    private void FixedUpdate()
    {
        scoreNum += 0.16f;
        timer++;
    }
}
