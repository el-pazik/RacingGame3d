using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text maxScore;
    private Text scoreText;

    public Text ScoreText
    {
        get
        {
            return scoreText;
        }
    }

    private int _score = 0;

    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            scoreText.text = $"{value}";
        }
    }

    private float timer = 0;

    private void Start()
    {
        maxScore.text = $"{PlayerPrefs.GetInt("MaxScore", 0)}";
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            Score += 1;
            timer = 0;
        }
    }

    public void ZeroCounter()
    {
        if(Score > PlayerPrefs.GetInt("MaxScore", 0))
        {
            PlayerPrefs.SetInt("MaxScore", Score);
            maxScore.text = $"{Score}";
        }
        Score = 0;
    }
}
