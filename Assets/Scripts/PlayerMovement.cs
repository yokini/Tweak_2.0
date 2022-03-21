using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject boomer;

    private Transform playerRotation;

    public Transform playerTip;

    private Vector2 lookDirection;
    private float lookAngle;

    

    
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * rotationSpeed;

        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        /*float horizontalValue = Input.GetAxis("Horizontal");

        if (horizontalValue > 0)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * -1);
        }

        else if (horizontalValue < 0)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime );
        }

        else
        {
            transform.Rotate(0, 0, 0);
        } */

        
        if (Input.GetMouseButtonDown(0))
        {
            ThrowBoom();

        }
        
            

        
    }

    public void ThrowBoom() 
        {
            
            GameObject clone;


            clone = Instantiate(boomer, playerTip.position, boomer.transform.rotation);  

        }

    
}










         