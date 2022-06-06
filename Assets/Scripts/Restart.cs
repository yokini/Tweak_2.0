using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{   
    int currentScene;

    void Start() 
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void RestartScene() 
    {
        SceneManager.LoadScene(currentScene);
    }
}
