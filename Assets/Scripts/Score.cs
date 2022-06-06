 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 
 public class Score : MonoBehaviour
 {
    public Text scoreText;
    public int score;
  
    void Start() 
    {
        scoreText.text = "SKILL!  " + score; 
    }
 
    public void AddScore() 
    {
        score = score + 100;
        scoreText.text = "SKILL!  " + score;
    }

    public void SubtractScore() 
    {
        score = score - 10;
        scoreText.text = "SKILL!  " + score;
    }

    public void WinScore()
    {
        if (score >= 100)
        {
            FindObjectOfType<GameStatus>().YesKey();
        }
        else
        {
            FindObjectOfType<GameStatus>().Nokey();
        }
    }

    void Update()
     {     
     }
}