﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeping : MonoBehaviour
{
    public Text score;

    int scoreNum;
    // Start is called before the first frame update
    void Start()
    {
      scoreNum = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreNum;
    }
}
