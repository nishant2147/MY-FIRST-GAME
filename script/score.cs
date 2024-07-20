using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;
    int myscore = 0;
    void Update()
    {
        scoreText.text = myscore.ToString();
        finalScoreText.text = "Score: "+myscore.ToString();
    }

    public void Addscore(int score)
    {
        myscore = myscore + score;
    }
}
