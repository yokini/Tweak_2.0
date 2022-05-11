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
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector3 direction = playerPos.position - transform.position;
        direction.Normalize();

        movement = direction;

        void OnTriggerEnter2D(Collider2D collider) {
            if (collider.tag == "Player") 
            {
                Destroy(collider.gameObject);
                Debug.Log("Enemy hit");
            }
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
}
