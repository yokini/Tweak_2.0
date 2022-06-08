using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    //This script dictates the enemy behaviour

    //Reference to the player position
    public Transform playerPos;

    //Rigidbody of the enemy
    private Rigidbody2D rb;

    //Normalized Direction where the enemy should move
    Vector2 movement;

    //Direction where the enemy should move
    Vector3 direction;

    //Spped of the enemy
    public float moveSpeed;

    //Delay time to boose the speed of the enemy
    public float boostSpeedDelay = 2f;

    //To increase the speed of the enemy after some time
    private float boostSpeed;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        //Referencing the constant player position from the manager
        playerPos = Skyler_MinigameManager.Instance.player;
    }
    
    void Update()
    {   
        //Calculate the distance between the enemy's position and player's position
        Vector3 direction = playerPos.position - transform.position;
        direction.Normalize();

        movement = direction;

        if (ShouldChangeSpeed()) 
        {
            ChangeSpeed();
        }
    }

    void FixedUpdate() 
    {
        MoveCharacter(movement);
    }

    //Move the character towards the direction calculated in update
    void MoveCharacter(Vector3 direction) 
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    //Change the enemy speed after boostdelay time
    void ChangeSpeed() 
    {
        boostSpeed = Time.time + boostSpeedDelay;
        moveSpeed += 1;
    }
    
    private bool ShouldChangeSpeed() 
    {
        return Time.time >= boostSpeed;
    }

    //Destroy yourself if you hit the player and the time is not finished
    //Decrease the player health by 10
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "Player") 
        {
            if (Skyler_MinigameManager.Instance.timer.currentTime > 0) 
            {
                if (Skyler_MinigameManager.Instance.playerHealth > 0 ) 
                {
                     Skyler_MinigameManager.Instance.playerHealth -= 10;
                }

                else 
                {
                    Skyler_MinigameManager.Instance.playerHealth = 0;
                }
                Destroy(this.gameObject); 
            }
        }
    }
}
