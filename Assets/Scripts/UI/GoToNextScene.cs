using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextScene : MonoBehaviour
{
    int currentScene; 
    int nextScene;

    void Start() 
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextScene() 
    { 
        nextScene = currentScene + 1;

        Debug.Log(nextScene);
        SceneManager.LoadScene(nextScene);
    }
}
