using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject musicBoxObject;


    public GameObject rubikCubeObject;

    public GameObject cookieJarObject;


    void Start()
    {
        musicBoxObject.SetActive(false);

        rubikCubeObject.SetActive(false);

        cookieJarObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
