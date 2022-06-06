using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    // River's Mini-Game Management
    // Declaring UI elements
    public GameObject restartPanel;
    public GameObject WinPanel;
    public Text scoreText;

    // Declaring variables
    public bool TimerOngoing;
    public bool hasWon;
    public GameObject SpawnManager;

    void Start()
    {
        // Initial values for winning/losing conditions
        TimerOngoing = true;
        // spawning active at the start
        SpawnManager.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Create Function to Load Next Scene and assign to Wake Up button HERE
    // SceneManager.LoadScene(scenename);

    //On collision with an obstacle, this function is called in the Obstacle Script
    public void OnPlayerkilled()
    {
        //Restart minigame button, timer and spawning of obstacles are stopped
        restartPanel.SetActive(true);
        TimerOngoing = false;
        SpawnManager.SetActive(false);
    }

    // Called when the timer hits zero and the player wins 
    // Spawning of obstacles are stopped
    public void OnTimerEnd()
    {
        if (!restartPanel.activeInHierarchy)
        {
            WinPanel.SetActive(true);
            TimerOngoing = false;
            SpawnManager.SetActive(false);
        }
    }
}
