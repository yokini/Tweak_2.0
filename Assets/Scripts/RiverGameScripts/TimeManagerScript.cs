using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManagerScript: MonoBehaviour
{
    // Time Management Scripy
    // Declaring Variabloes
    public Text timeText;
    private float time;
    public GameManagerScript gm;

    void Start()
    {
        // Assigning Variables
        gm = FindObjectOfType<GameManagerScript>();
        // Assigning Game time length
        time = 31;
    }

    void Update()
    {
        // Countdown
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        // Call end of game function from Game Manager Script
        else
        {
            time = 0;
            gm.OnTimerEnd();
        }

        // whenever game ends (time = 0 or collision with obstacle)
        if(gm.TimerOngoing == false)
        {
            timeText.text = null;
        }

        // Display countdown
        else
        {
            timeText.text = ((int)time).ToString();
        }
    }
}
