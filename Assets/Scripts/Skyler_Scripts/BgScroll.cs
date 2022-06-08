using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{   
    // This script creates a background loop to create an illusion of endless falling

    //Spped of the background movement
    public float speed = 4f;

    //Maximum point till which the background can move
    public float maximumHeight = 15f;

    //Reference to the starting position
    Vector3 startPosition;
    
    void Start()
    {   
        //Starting position of the background
        startPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Keep moving background up until you don't reach the maximum height
        //If you reach maximum height, Start from the beginning
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.y > maximumHeight)
        {
            transform.position = startPosition;
        }   
    }
}
