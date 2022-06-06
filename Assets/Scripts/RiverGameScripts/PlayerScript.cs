using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // River's Mini Game Player Movement Script
    // Declaring variables
    private float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public GameManagerScript gm;

    // Start is called before the first frame update
    void Start()
    {
        // Assigning values
        rb = GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<GameManagerScript>();
        playerSpeed = 12;
    }

    // Update is called once per frame
    void Update()
    {
        //  Vertical Inputs, no Horizontal Input
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY);

        // Still player when game has been stopped
        if (gm.TimerOngoing == false)
        {
            playerSpeed = 0;
        }
    }
    private void FixedUpdate()
    {
        // Movement of player
        rb.velocity = playerDirection * playerSpeed;
    }

}
