using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject WinPanel;
    public Text scoreText;
    public GameManagerScript instance;
    public bool TimerOngoing;
    public bool hasWon;
   
    public void Awake()
    {
        if (instance != null)
        {
            Destroy(instance); 
        }
        
        instance = this;
    }

    void Start()
    {
        TimerOngoing = true;
        hasWon = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnPlayerDestroyed()
    {
        restartPanel.SetActive(true);
        TimerOngoing = false;
    }

    public void OnTimerEnd()
    {
        WinPanel.SetActive(true);
        TimerOngoing = false;
        hasWon = true;
    }
}
