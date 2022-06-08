using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRiverGame : MonoBehaviour
{
    public void LoadRiverMiniGame() 
    {
        SceneManager.LoadScene(8);
        Debug.Log("You are in River's minigame");
        
    }
}
