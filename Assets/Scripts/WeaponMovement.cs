using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    Transform itemRotate;
    public float rotationSpeed;

    void Start()
    {
        rb.velocity = transform.up * speed;   

        itemRotate = gameObject.transform;
    }

    void Update() 
    {
        itemRotate.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);

    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log(collider.name);
        Destroy(gameObject);

        if (collider.tag == "Enemy") 
        {
            Destroy(collider.gameObject);
        }
    }

    
}
