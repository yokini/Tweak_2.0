using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {         
            Destroy(collision.gameObject);

            Debug.Log("Hit");

    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boomer"))
        {
            Destroy(other.gameObject);

           Debug.Log("Hit");
        }
    } 

    
}
