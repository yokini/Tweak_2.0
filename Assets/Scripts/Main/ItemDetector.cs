using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetector : MonoBehaviour
{
    public Image sprite;
    public Sprite check;


    
    

    void CheckThis()
    {
        if (sprite.GetComponent<Image>() == check)
        {
            Debug.Log("itworks");
        }
         else
        {
            Debug.Log("noyes");
        }
    }
    
    
}
