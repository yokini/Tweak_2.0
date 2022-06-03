using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PickUpObject : MonoBehaviour
{
    public GameObject musicBoxButton;
    public GameObject kazooButton;
    public GameObject alarmClockButton;

    ObjectManager ObjectManager;
    
    void Start()
    {
        ObjectManager = FindObjectOfType<ObjectManager>();
    }

    
    void Update()
    {
        
    }

    public void JustMoveOnMusicBox() 
    {
        if (musicBoxButton.CompareTag("MusicBox")) 
        {
            SceneManager.LoadScene(0);
            ObjectManager.musicBox = true;
            ObjectManager.robinGameOver = true;
        }
    }

    public void JustMoveOnKazoo() 
    {
         if (kazooButton.CompareTag("Kazoo")) 
        {
            SceneManager.LoadScene(0);
            ObjectManager.kazoo = true;
            ObjectManager.robinGameOver = true;
        }
    }

    public void JustMoveOnAlarmClock() 
    {

         if (alarmClockButton.CompareTag("AlarmClock")) 
        {
            SceneManager.LoadScene(0);
            ObjectManager.alarmClock = true;
            ObjectManager.robinGameOver = true;
        }
    }

    

   
}
