using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This script controls the movement of the player

    //How fast the player should rotate
    public float rotationSpeed;

    
    public Transform playerTip;

    //position to where the player should rotate towards
    private Vector2 lookDirection;

    //Angle to move the player towards look direction
    private float lookAngle;

    //How fasr the player should move
    public float moveSpeed;

    //Reference for the horizontal direction of the player
    private float horizontalValue;

    //Reference to the vertical direction of the player
    private float verticalValue;

    public Rigidbody2D rb;

    

    

    

    
    void Start()
    {
        

        rb = GetComponent<Rigidbody2D>(); 
      
    }

    // Update is called once per frame
    void Update()
    {   
        //Calculate the difference between the mouseposition and player's position
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        //Calculate the angle to rotate towards mouse position
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * rotationSpeed;

        //Rotate the player by the the value in lookAngle
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Value to move in horizontal direction
        horizontalValue = Input.GetAxis("Horizontal")*moveSpeed;

        //Value to move in vertical direction
        verticalValue = Input.GetAxis("Vertical")*moveSpeed;


        void OnTriggerEnter2D(Collider2D collider) 
        {
            if (collider.tag == "Enemy") 
            {
                Destroy(gameObject);
                Debug.Log("Enemy hit");
            }
        }
        

    }

    

      
    //Function to move the player in horizontal and vertical direction
     private void FixedUpdate() 
    {
        Vector2 velocity = rb.velocity;
        velocity.x = horizontalValue;
        velocity.y = verticalValue;
        rb.velocity = velocity;
    } 
}










         