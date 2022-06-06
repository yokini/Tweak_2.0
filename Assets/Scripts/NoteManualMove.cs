using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManualMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public void Move()
    {
        rb.velocity = new Vector2(0, -speed);
    }
}
