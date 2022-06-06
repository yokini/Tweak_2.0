using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    public Transform playerPos;
    private Rigidbody2D rb;
    Vector2 movement;

    Vector3 direction;

    public float moveSpeed;
    public float boostSpeedDelay = 2f;
    private float boostSpeed;
    
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        playerPos = Skyler_MinigameManager.Instance.player;
    }

    
    void Update()
    {
        Vector3 direction = playerPos.position - transform.position;
        direction.Normalize();

        movement = direction;

        

        if (ShouldChangeSpeed()) 
        {
            ChangeSpeed();
            //Debug.Log(moveSpeed);

        }

        
         
        
    }

    void FixedUpdate() 
    {
        MoveCharacter(movement);
    }

    void MoveCharacter(Vector3 direction) 
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void ChangeSpeed() 
    {
        boostSpeed = Time.time + boostSpeedDelay;
        moveSpeed += 1;

    }

    private bool ShouldChangeSpeed() 
    {
        return Time.time >= boostSpeed;
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log(collider.name);

        /*if (collider.tag == "Player") 
        {
            if (Skyler_MinigameManager.Instance.timer.currentTime > 0) 
            {
                Debug.Log(collider.name);
                Destroy(gameObject);
                Skyler_MinigameManager.Instance.playerHealth -= 10;
                Debug.Log(Skyler_MinigameManager.Instance.playerHealth);
            }

            
        }*/
    }
}
