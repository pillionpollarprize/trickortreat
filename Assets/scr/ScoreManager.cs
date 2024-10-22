using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int theScore = 0;
    public TextMeshProUGUI scoreText;
    public void UpdateScore(int score)
    {
        theScore += score;
        scoreText.text = theScore.ToString("D4");
    }
}
