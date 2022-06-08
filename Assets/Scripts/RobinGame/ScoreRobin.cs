 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 
 public class ScoreRobin : MonoBehaviour
 {
     //This script updates the score UI

     //References text and score number
    public Text scoreText;
    public int score;
  
    void Start() 
    {
        //Start UI
        scoreText.text = "SKILL!  " + score; 
    }
 
    public void AddScore() 
    {
        //For each activator activated the score updates with + 100 points
        score = score + 100;
        scoreText.text = "SKILL!  " + score;
    }

    public void SubtractScore() 
    {
        //For each missed activation and not in uncoordinated button press the score updates with -10 points
        score = score - 10;
        scoreText.text = "SKILL!  " + score;
    }

    public void WinScore()
    {
        //Activates the UI. The condition is more than 1400 points to win.
        if (score >= 1400)
        {
            FindObjectOfType<GameStatus>().YesKey();
        }
        else
        {
            FindObjectOfType<GameStatus>().Nokey();
        }
    }
}