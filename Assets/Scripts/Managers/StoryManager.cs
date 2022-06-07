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

    // Loads Robin mingame
    public void LoadRobinMiniGame() 
    {
        SceneManager.LoadScene(1);
        Debug.Log("You are in Robin's minigame");
    }

    //Loads River minigame
    public void LoadRiverMiniGame() 
    {
        SceneManager.LoadScene(2);
        Debug.Log("You are in River's minigame");
        
    }

    //Loads skyler minigame
    public void LoadSkylerMiniGame() 
    {
        SceneManager.LoadScene(3);
        Debug.Log("You are in Skyler's minigame");
    }

    




}
