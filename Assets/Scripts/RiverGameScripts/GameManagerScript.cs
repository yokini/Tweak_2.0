using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject WinPanel;
    public Text scoreText;
    public bool TimerOngoing;
    public bool hasWon;

    void Start()
    {
        TimerOngoing = true;
        hasWon = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Create Function to Load Next Scene and assign to Wake Up button

    public void OnPlayerkilled()
    {
        restartPanel.SetActive(true);
        TimerOngoing = false;
    }

    public void OnTimerEnd()
    {
        if (!restartPanel.activeInHierarchy)
        {
            WinPanel.SetActive(true);
            TimerOngoing = false;
            hasWon = true;
        }
    }
}
