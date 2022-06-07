using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject musicBoxObject;
    void Start()
    {
        musicBoxObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectManager.instance.musicBox) 
        {
            musicBoxObject.SetActive(true);
        }
    }
}
