using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StoryManager : MonoBehaviour
{   
    //This script manages which minigame to load

    //Singleton reference
    public static StoryManager instance;
    
    //Singleton
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("more than one instance found");
            return;
        }
        instance = this;

        DontDestroyOnLoad(this.gameObject);
        
    }

    public void LoadRobinSalamander() 
    {
        SceneManager.LoadScene(4);
    }

    public void LoadRiverSalamander() 
    {
        SceneManager.LoadScene(5);
    }

    public void LoadSkylerSalamander() 
    {
        SceneManager.LoadScene(6);
    }

    // Loads Robin mingame
    public void LoadRobinMiniGame() 
    {
        SceneManager.LoadScene(7);
        Debug.Log("You are in Robin's minigame");
    }

    //Loads River minigame
    public void LoadRiverMiniGame() 
    {
        SceneManager.LoadScene(8);
        Debug.Log("You are in River's minigame");
        
    }

    //Loads skyler minigame
    public void LoadSkylerMiniGame() 
    {
        SceneManager.LoadScene(9);
        Debug.Log("You are in Skyler's minigame");
    }

    




}
