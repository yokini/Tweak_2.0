using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    void Awake()//object ref before
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.velocity = new Vector2(0, -speed);
    }

    void Update()
    {
    }
}
