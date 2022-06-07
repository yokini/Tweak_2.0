using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    //This script is used to update the Inventory UI if inventory gets updated

    //Reference to the all collectable objects in minigames
    public GameObject musicBoxObject;


    public GameObject rubikCubeObject;

    public GameObject cookieJarObject;


    void Start()
    {   
        //Disabling all Gameobjects in the slot when the main scene loads. 
        //These objects will be activated according to what player chooses in a minigame
        musicBoxObject.SetActive(false);

        rubikCubeObject.SetActive(false);

        cookieJarObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Objects in the Inventory slots get activated according to what objects player chooses
        
        if (ObjectManager.instance.musicBox) 
        {
            musicBoxObject.SetActive(true);
        }

        if (ObjectManager.instance.rubikCube) 
        {
            rubikCubeObject.SetActive(true);
        }

        if (ObjectManager.instance.cookies) 
        {
            cookieJarObject.SetActive(true);
        }

    }
}
