using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skyler_MinigameManager : MonoBehaviour
{
    private static Skyler_MinigameManager _instance;

    public static Skyler_MinigameManager Instance 
    {
        get
        {
            if (_instance == null) 
            {
                GameObject go = new GameObject("Skyler_MinigameManager");
                go.AddComponent<Skyler_MinigameManager>();
            }

            return _instance;
        }
    }

    void Awake()  
    {
        _instance = this;
    }

    public Transform player;

    public float score;

    public GameObject winPanel;
    public GameObject losePanel;

    public Skyler_Timer timer;

    public int playerHealth;

    void Start()
    {
        score = 0;

        winPanel.SetActive(false);
        losePanel.SetActive(false);

        timer = FindObjectOfType<Skyler_Timer>();

        playerHealth = 100;
    }

    void Update() 
    {
        
        if (playerHealth <= 0) 
        {
            losePanel.SetActive(true);
        }
        
        if ( timer.currentTime == 0 && playerHealth != 0 ) 
        {
            winPanel.SetActive(true);
        }
    }

    public void LoadSkylerObject() 
    {
        SceneManager.LoadScene(12);
    }
}
