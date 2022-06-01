using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject WinPanel;
    public Text scoreText;

    public GameManagerScript instance;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance); 
        }

        else
        {
            instance = this;
        }
        
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnPlayerDestroyed()
    {
        restartPanel.SetActive(true);    
    }

    public void OnTimerEnd()
    {
        WinPanel.SetActive(true);
    }
}
