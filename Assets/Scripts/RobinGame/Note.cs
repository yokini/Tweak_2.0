using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    //This script sets up the note when the game is started
    
    Rigidbody2D rb;
    public float speed;
    
    void Awake()//object ref before
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        //Sets up the speed for the object from the start
        rb.velocity = new Vector2(0, -speed);
    }
}
