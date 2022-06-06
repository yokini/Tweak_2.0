using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaseScript : MonoBehaviour
{
    // This script is being used to add speed to the obstacles being instantiated, based on the game time and not their instantiation time
    // Declaring variable
    public float speed;

    void Start()
    {
        // Assigning values
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Increasing the speed over time, to be added to the obstacles' speed in the Obstacle Script
        speed = speed + 0.005f;
    }
}
