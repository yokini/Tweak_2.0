using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRobinGame : MonoBehaviour
{
   public void LoadRobinMiniGame() 
    {
        SceneManager.LoadScene(7);
        Debug.Log("You are in Robin's minigame");
    }
}
