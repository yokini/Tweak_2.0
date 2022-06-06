using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Obstacle Behaviour Script
    // Declaring Variables
    public float speed;
    public GameManagerScript gm;
    public SpeedIncreaseScript speedInc;

    void Start()
    {
        // Assigning values and Scripts
        gm = FindObjectOfType<GameManagerScript>();
        speedInc = FindObjectOfType<SpeedIncreaseScript>();
        // Increasing the speed of obstacles being instantiated, based on the game time and not their instantiation time
        speed = speed + speedInc.speed;
    }

    void Update()
    {
        // movement to the left
        transform.Translate(Vector2.left * Time.deltaTime * speed);
            // still obstacles when the game is not ongoing
            if (gm.TimerOngoing == false)
                {
                    speed = 0;
                }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Detecting collision with left collider to destroy obstacles offscreen
        if(collision.tag == "Collider")
        {
            Destroy(this.gameObject);
        }

        // Detecting collision with player to still player and call losing conditions
        else if (collision.tag == "Player")
        {
            speed = 0;
            gm.OnPlayerkilled();
        }
    }
}
