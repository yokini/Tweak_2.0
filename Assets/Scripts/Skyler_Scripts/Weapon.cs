using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
   public Transform playerTip;
   public GameObject boomerang;

   public AudioSource audioSource;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {  
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }    
    }

    private void Shoot()
    {
        Instantiate(boomerang, playerTip.position, playerTip.rotation);
        audioSource.Play();
    }
}
