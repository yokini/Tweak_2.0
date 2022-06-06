using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeping : MonoBehaviour
{
    public Text score;

    int scoreNum;

    void Start()
    {
      
      
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Skyler_MinigameManager.Instance.score;

        
    }
}
