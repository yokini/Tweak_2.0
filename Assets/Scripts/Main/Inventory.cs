using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    //public Object musicBoxObject;

    //public ObjectManager ObjectManager;

   

    Clickable clickable;

    int currentScene;

    public static Inventory instance;

    

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("more than one instance found");
            return;
        }
        instance = this;

        DontDestroyOnLoad(this.gameObject);
        
    }

    
    void Start()
    {
        //ObjectManager = FindObjectOfType<ObjectManager>();

       

        



       

        
    }

    
    void Update()
    {
      
    }

    /*public void JustMoveOnMusicBox() 
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
    }*/

    public void MoveOn( string tag, GameObject obj) 
    {
        if (SceneManager.GetActiveScene().buildIndex == 5) 
        {
             clickable = FindObjectOfType<Clickable>();

            tag = clickable.target;
            obj = clickable.objectHolder;
        }
       
        if (obj.CompareTag(tag)) 
        {
            SceneManager.LoadScene(0);

            if (tag == "MusicBox") 
            {
                ObjectManager.instance.musicBox = true;
            }

            if (tag == "Kazoo") 
            {
                ObjectManager.instance.kazoo = true;
            }

            if (tag == "AlarmClock") 
            {
                ObjectManager.instance.alarmClock = true;
            }

            if (tag == "MusicBox" || tag == "Kazoo" || tag == "AlarmClock" ) 
            {
                ObjectManager.instance.robinGameOver = true;
            }

        }
    }

   
   
}
