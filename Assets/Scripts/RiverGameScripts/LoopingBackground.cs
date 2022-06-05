﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    public GameManagerScript gm;
    public RiverTimer rt;

    void Start()
    {
        gm = FindObjectOfType<GameManagerScript>();
        rt = FindObjectOfType<RiverTimer>();
        backgroundSpeed = 0.5f;
        
    }

    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime,0f);
        if (gm.hasWon == true || gm.TimerOngoing == false)
        {
            backgroundSpeed = 0;  
        }

        backgroundSpeed = backgroundSpeed + 0.0001f;
    }
}
