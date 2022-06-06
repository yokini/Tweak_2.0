using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Image healthBar;

    public float currentHealth;
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
        currentHealth = miniGameManager.playerHealth;
        healthBar.fillAmount = currentHealth/maxHealth;

    }
}
