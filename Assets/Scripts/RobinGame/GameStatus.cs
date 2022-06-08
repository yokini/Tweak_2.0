using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    public Image renderWin;
    public Image renderLose;


    void Start()
    {   
    }

    public void YesKey()
    {
        renderWin.gameObject.SetActive(true);
    }

    public void Nokey()
    {
        renderLose.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(7);
    }

    public void WakeUp()
    {
        SceneManager.LoadScene(10);
    }
}
