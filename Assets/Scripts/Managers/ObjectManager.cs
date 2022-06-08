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
     

    //public GameObject musicBoxObject;
    //public Vector2 MusicBoxPos;
    //public GameObject kazooSprite;
    //public GameObject alarmClockSprite;

     /*public GameObject rubikCubeSprite;
     public GameObject butterflyBookSprite;
     public GameObject stonehengePhotoSprite;

     public GameObject cookiesSprite;
     public GameObject wineSprite;
     public GameObject croissantsSprite;*/

    //Variables to check if the player has selected a correct object
    public bool riverObject;
    public bool skylerObject;
    public bool robinObject;

    //Variables to check if the minigame is finished
    public bool riverGameOver;
    public bool skyleGameOver;
    public bool robinGameOver;

    //Reference to the button which will pop up when all minigames are finished
    public GameObject EndIsNearButton;

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
        

        //musicBoxObject.SetActive(false);
        //kazooSprite.SetActive(false);
        //alarmClockSprite.SetActive(false);

        /*rubikCubeSprite.SetActive(false);
        butterflyBookSprite.SetActive(false);
        musicBoxSprite.SetActive(false);*/

        //To disable the end button in the beginning of the game

        //EndIsNearButton.SetActive(false);

       

        



        isEndNearDone = false;

    }

    void Update()
    {
        CheckObjects();
        //CheckEnd();
        EndIsNear();

        /*EndIsNearButton = GameObject.Find("EndButton");

        if (riverGameOver && skyleGameOver && robinGameOver) 
        {
            EndIsNearButton.SetActive(true);
        }

        else 
        {
            EndIsNearButton.SetActive(false);
        }*/
    }

    //This function checks if the selected object is the correct one or not
    public void CheckObjects() 
    {
        if(musicBox == true) 
        {
            robinObject = true;
            //Debug.Log("This is " + robinObject);
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

    // Enables the end button if all minigames are over
    public void EndIsNear() 
    {
        if (riverGameOver && skyleGameOver && robinGameOver) 
        {
            EndIsNearButton.SetActive(true);
        }
    }

    //Makes sure to check if all minigames are over only once in update
    public void CheckEnd()
    {
        if (isEndNearDone == false) 
        {
            EndIsNear();
            isEndNearDone =true;
        }
    }
}
