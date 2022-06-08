using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIpopUp : MonoBehaviour
{
    public GameObject canvas;

    public GameObject chooseObject;

    void Start()
    {
        canvas.SetActive(false);
    }

    public void OpenUI() 
    {
        canvas.SetActive(true);
        chooseObject.SetActive(false);
    }
}
