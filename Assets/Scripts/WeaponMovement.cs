using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    Transform itemRotate;
    public float rotationSpeed;

    Skyler_Timer timer;

    void Start()
    {
        rb.velocity = transform.up * speed;   

        itemRotate = gameObject.transform;

        timer = FindObjectOfType<Skyler_Timer>();
    }

    void Update() 
    {
        itemRotate.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);

    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log(collider.name);
        

        if (collider.tag == "Enemy") 
        {
            Destroy(collider.gameObject);
            Destroy(this.gameObject);

            if (timer.currentTime > 0) 
            {
                Skyler_MinigameManager.Instance.score += 1;
            }

            
        }
    }

    
}
