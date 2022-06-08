using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    Clickable clickable;

    int currentScene;

    public static Inventory instance;

    // Singleton
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
   
    //Function to update the inventory in the main scene. It updates the inventory on the basis of what object was selected
    //It also checks whether the minigame is finished by the player or not. 
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
            SceneManager.LoadScene(3);

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

             if (tag == "RubikCube") 
            {
                ObjectManager.instance.rubikCube = true;
            }

            if (tag == "ButterflyBook") 
            {
                ObjectManager.instance.butterflyBook = true;
            }

            if (tag == "StonehengePhoto") 
            {
                ObjectManager.instance.stonehengePhoto = true;
            }

            if (tag == "RubikCube" || tag == "ButterflyBook" || tag == "StonehengePhoto" ) 
            {
                ObjectManager.instance.riverGameOver = true;
            }

            if (tag == "Cookies") 
            {
                ObjectManager.instance.cookies = true;
            }

            if (tag == "Wine") 
            {
                ObjectManager.instance.wine = true;
            }

            if (tag == "Croissants") 
            {
                ObjectManager.instance.croissants = true;
            }

            if (tag == "Cookies" || tag == "Wine" || tag == "Croissants" ) 
            {
                ObjectManager.instance.skyleGameOver = true;
                Debug.Log("RobinGameOver");
            } 
        }
    }
}
