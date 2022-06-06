using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skyler_Timer : MonoBehaviour
{
    public float currentTime;

    float startingTime;

    public Text countdownText;

    void Start()
    {
        startingTime = currentTime;
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0 ) 
        {
            currentTime = 0;
        }

        if (currentTime <= 10) 
        {
            countdownText.color = Color.red;
        }

        
    }
}
