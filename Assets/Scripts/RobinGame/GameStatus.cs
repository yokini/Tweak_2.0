using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    //This script shows the game over UI and loads scenes depending on the win/lose condition
    public Image renderWin;
    public Image renderLose;

    //If the score is more than 1400, the win UI gets activated
    public void YesKey()
    {
        renderWin.gameObject.SetActive(true);
    }

    //If the score is less than 1400, the lose UI gets activated
    public void Nokey()
    {
        renderLose.gameObject.SetActive(true);
    }

    //Button restarts the scene
    public void RestartGame()
    {
        SceneManager.LoadScene(7);
    }

    //Button moves on to the next scene
    public void WakeUp()
    {
        SceneManager.LoadScene(10);
    }
}
