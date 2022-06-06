using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTimeRobin : MonoBehaviour
{  
    public float setTime = 12.0f;

    void Update()
    {
        setTime -= Time.deltaTime;
 
        if (setTime <= 0.0f)
        {
            FindObjectOfType<ScoreRobin>().WinScore();
        }
    }
}
