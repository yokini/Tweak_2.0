using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StoryManager : MonoBehaviour
{   
    public static StoryManager instance;
    
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

    public void LoadRobinMiniGame() 
    {
        SceneManager.LoadScene(1);
        Debug.Log("You are in Robin's minigame");
    }

    public void LoadRiverMiniGame() 
    {
        SceneManager.LoadScene(2);
        Debug.Log("You are in River's minigame");
        
    }

    public void LoadSkylerMiniGame() 
    {
        SceneManager.LoadScene(3);
        Debug.Log("You are in Skyler's minigame");
    }




}
