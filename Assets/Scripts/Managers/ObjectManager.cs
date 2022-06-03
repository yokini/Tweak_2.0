using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ObjectManager : MonoBehaviour
{
    public static ObjectManager instance;

    public bool musicBox = false;
    public bool kazoo = false;
    public bool alarmClock = false;

    public bool rubikCube = false;
    public bool butterflyBook = false;
    public bool stonehengePhoto = false;

    public bool cookies = false;
    public bool wine = false;
    public bool croissants = false;
     

    public GameObject musicBoxSprite;
    public GameObject kazooSprite;
    public GameObject alarmClockSprite;

     /*public GameObject rubikCubeSprite;
     public GameObject butterflyBookSprite;
     public GameObject stonehengePhotoSprite;

     public GameObject cookiesSprite;
     public GameObject wineSprite;
     public GameObject croissantsSprite;*/


    public bool riverObject;
    public bool skylerObject;
    public bool robinObject;

    public bool riverGameOver;
    public bool skyleGameOver;
    public bool robinGameOver;

    public GameObject EndIsNearButton;

    public bool isEndNearDone;



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
        musicBoxSprite.SetActive(false);
        kazooSprite.SetActive(false);
        alarmClockSprite.SetActive(false);

        /*rubikCubeSprite.SetActive(false);
        butterflyBookSprite.SetActive(false);
        musicBoxSprite.SetActive(false);*/

        EndIsNearButton.SetActive(false);

        isEndNearDone = false;
    }

    void Update()
    {
        ActiveObjects();
        CheckObjects();
        CheckEnd();
    }



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

    public void ActiveObjects()
    {
        if(musicBox == true) 
        {
            musicBoxSprite.SetActive(true);
        }

        if(kazoo == true) 
        {
            kazooSprite.SetActive(true);
        }

        if(alarmClock == true) 
        {
            alarmClockSprite.SetActive(true);
        }
    }

    public void EndScenes() 
    {
        if (robinObject && riverObject && skylerObject) 
        {
            SceneManager.LoadScene(2);
        }

        else if ((robinObject && riverObject) || (robinObject && skylerObject) || (riverObject && skylerObject) ) 
        {
            SceneManager.LoadScene(3);
        }

        else if (robinObject || riverObject || skylerObject) 
        {
            SceneManager.LoadScene(4);
        }

        else if (!robinObject || !riverObject || !skylerObject) 
        {
            SceneManager.LoadScene(5);
        }
    }

    public void EndIsNear() 
    {
        if (riverGameOver && skyleGameOver && robinGameOver) 
        {
            EndIsNearButton.SetActive(true);
        }
    }

    public void CheckEnd()
    {
        if (isEndNearDone == false) 
        {
            EndIsNear();
            isEndNearDone =true;
        }
    }
}
