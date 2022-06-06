using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackgroundScript : MonoBehaviour
{
    // Script for background movement
    // Declaring Variables
    private float backgroundSpeed;
    public Renderer backgroundRenderer;
    public GameManagerScript gm;

    void Start()
    {
        // Assigning values and scripts
        gm = FindObjectOfType<GameManagerScript>();
        backgroundSpeed = 0.5f;
    }

    void Update()
    {
        // Background movement
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime,0f);
        
        // Stopping motion when the game is not ongoing
        if (gm.TimerOngoing == false)
        {
            backgroundSpeed = 0;  
        }

        // Increasing the speed of the motion over time
        backgroundSpeed = backgroundSpeed + 0.0001f;
    }
}
