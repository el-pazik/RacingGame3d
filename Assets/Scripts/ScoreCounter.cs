using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private Text scoreText;

    public Text ScoreText
    {
        get
        {
            return scoreText;
        }
    }

    private float timer = 0;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            scoreText.text = $"{Convert.ToInt32(scoreText.text) + 1}";
            timer = 0;
        }
    }
}
