using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    //This script is not used anymore 
    
    public Transform target;

    public Rigidbody rb;

    public float force;

    private Renderer renderer;

    private Vector2 screenBounds;

    public float f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        //renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 f = target.position - transform.position;
        f = f.normalized;
        f = f * force;
        rb.AddForce(f);   
    }
}
