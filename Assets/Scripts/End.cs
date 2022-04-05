using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{  
    public float setTime = 12.0f;
 
    void timerEnded()
    {
        //I have to figure this one out!
    }

    void Update()
    {
        setTime -= Time.deltaTime;
 
        if (setTime <= 0.0f)
        {
            FindObjectOfType<Score>().WinScore();
        }
    }
}
