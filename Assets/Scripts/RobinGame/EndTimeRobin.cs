using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTimeRobin : MonoBehaviour
{  
    //This code triggers after 12 seconds of play the win/lose panel which checks for the condition
    public float setTime = 12.0f;

    //Updates countdown time
    void Update()
    {
        setTime -= Time.deltaTime;
 
        if (setTime <= 0.0f)
        {
            FindObjectOfType<ScoreRobin>().WinScore();
        }
    }
}
