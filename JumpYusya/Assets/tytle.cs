using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tytle : MonoBehaviour
{
    public TextMeshProUGUI gameover;
    public float speed = 1.0f;
    float timer;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameover.color = GetAlphaColor(gameover.color);
    }

    Color GetAlphaColor(Color color)
    {
        timer += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(timer);
        return color;
    }
}
