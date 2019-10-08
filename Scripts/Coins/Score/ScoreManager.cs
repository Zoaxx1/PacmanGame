using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;

    public Text scoreText;

    public int score = 0;

    void Start()
    {
        scoreManager = this;
    }

    public void RaiseScore(int s)
    {
        score += s;
        scoreText.text = score + "";
        if(score == 100)
        {
            Time.timeScale = 0;
        }
    }

}
