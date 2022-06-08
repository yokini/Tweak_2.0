using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    //This script update the health bar 

    //Reference to the healthbar image
    public Image healthBar;

    //Current health of the player
    public float currentHealth;

    // Maximum health of the player
    private float maxHealth = 100f;

    

    Skyler_MinigameManager miniGameManager;

    
    
    void Start()
    {
        miniGameManager = FindObjectOfType<Skyler_MinigameManager>();
        //healthBar = GetComponent<Image>();
       
        

    }
    

    // Update is called once per frame
    void Update()
    {   
        //Reference the health from the manager
        currentHealth = miniGameManager.playerHealth;

        //Change the fill amount according the current health of the player
        healthBar.fillAmount = currentHealth/maxHealth;

    }
}
