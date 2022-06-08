using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ObjectManager : MonoBehaviour
{
    //Singleton reference
    public static ObjectManager instance;

    // Variables to check what objects were collected from minigames
    public bool musicBox = false;
    public bool kazoo = false;
    public bool alarmClock = false;

    public bool rubikCube = false;
    public bool butterflyBook = false;
    public bool stonehengePhoto = false;

    public bool cookies = false;
    public bool wine = false;
    public bool croissants = false;

    //Variables to check if the player has selected a correct object
    public bool riverObject;
    public bool skylerObject;
    public bool robinObject;

    //Variables to check if the minigame is finished
    public bool riverGameOver;
    public bool skyleGameOver;
    public bool robinGameOver;

    //Reference to the button which will pop up when all minigames are finished
    //public GameObject EndIsNearButton;

    //Variable to run the function only once in update
    public bool isEndNearDone;


    //Singleton
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
        isEndNearDone = false;
    }

    void Update()
    {
        CheckObjects();
    }

    //This function checks if the selected object is the correct one or not
    public void CheckObjects() 
    {
        if(musicBox == true) 
        {
            robinObject = true;
        }

        if(rubikCube == true) 
        {
            riverObject = true;
        }

        if (cookies == true) 
        {
            skylerObject = true;
        }
    }

    //This functions manages different endings according to what objects player select in minigames
    public void EndScenes() 
    {
        if (robinObject && riverObject && skylerObject) 
        {
            SceneManager.LoadScene(7);
        }

        else if ((robinObject && riverObject) || (robinObject && skylerObject) || (riverObject && skylerObject) ) 
        {
            SceneManager.LoadScene(8);
        }

        else if (robinObject || riverObject || skylerObject) 
        {
            SceneManager.LoadScene(9);
        }

        else if (!robinObject || !riverObject || !skylerObject) 
        {
            SceneManager.LoadScene(10);
        }
    }
}
