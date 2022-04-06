using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject WinPanel;
    public Text scoreText;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnPlayerDestroyed()
    {
       restartPanel.SetActive(true);
       
        if (scoreText.text == "0")
       {
        WinPanel.SetActive(true);
       }
    }
}
