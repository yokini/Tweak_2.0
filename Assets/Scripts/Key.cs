using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Image renderWin;
    public Image renderLose;


    void Start()
    {   
    }

    public void YesKey()
    {
        renderWin.gameObject.SetActive(true);
    }

    public void Nokey()
    {
        renderLose.gameObject.SetActive(true);
    }

    void Update()
    {  
    }
}
