using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //tracks score
    public TextMeshProUGUI scoreText; //visual text for score

    public void IncreaseScore(int amount)
    {
        score =+ amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
