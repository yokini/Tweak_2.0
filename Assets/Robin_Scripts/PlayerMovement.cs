using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed;

    public Transform playerTip;

    private Vector2 lookDirection;
    private float lookAngle;

    public float moveSpeed;
    private float horizontalValue;
    private float verticalValue;

    public Rigidbody2D rb;

    

    

    

    
    void Start()
    {
        

        rb = GetComponent<Rigidbody2D>(); 
      
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * rotationSpeed;

        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        horizontalValue = Input.GetAxis("Horizontal")*moveSpeed;
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

    

      

     private void FixedUpdate() 
    {
        Vector2 velocity = rb.velocity;
        velocity.x = horizontalValue;
        velocity.y = verticalValue;
        rb.velocity = velocity;
    } 
}










         