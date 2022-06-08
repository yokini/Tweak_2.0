using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    //This script is used to update the Inventory UI if inventory gets updated

    //Reference to the all collectable objects in minigames
    public GameObject musicBoxObject;
    public GameObject kazooObject;
    public GameObject alarmClockObject;


    public GameObject rubikCubeObject;
    public GameObject butterflyBookObject;
    public GameObject stonehengePhotoObject;

    public GameObject cookieJarObject;
    public GameObject wineObject;
    public GameObject croissantsObject;


    void Start()
    {   
        //Disabling all Gameobjects in the slot when the main scene loads. 
        //These objects will be activated according to what player chooses in a minigame
        musicBoxObject.SetActive(false);
        kazooObject.SetActive(false);
        alarmClockObject.SetActive(false);

        rubikCubeObject.SetActive(false);
        butterflyBookObject.SetActive(false);
        stonehengePhotoObject.SetActive(false);

        cookieJarObject.SetActive(false);
        wineObject.SetActive(false);
        croissantsObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Objects in the Inventory slots get activated according to what objects player chooses
        
        if (ObjectManager.instance.musicBox) 
        {
            musicBoxObject.SetActive(true);
        }

         if (ObjectManager.instance.kazoo) 
        {
            kazooObject.SetActive(true);
        }

         if (ObjectManager.instance.alarmClock) 
        {
            alarmClockObject.SetActive(true);
        }

        if (ObjectManager.instance.rubikCube) 
        {
            rubikCubeObject.SetActive(true);
        }

         if (ObjectManager.instance.butterflyBook) 
        {
            butterflyBookObject.SetActive(true);
        }

         if (ObjectManager.instance.stonehengePhoto) 
        {
            stonehengePhotoObject.SetActive(true);
        }

        if (ObjectManager.instance.cookies) 
        {
            cookieJarObject.SetActive(true);
        }

         if (ObjectManager.instance.wine) 
        {
            wineObject.SetActive(true);
        }

         if (ObjectManager.instance.croissants) 
        {
            croissantsObject.SetActive(true);
        }

    }
}
