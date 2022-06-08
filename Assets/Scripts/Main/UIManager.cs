using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject darkChar;
    public GameObject darkBG;
    public GameObject buttons;
    public GameObject backpack;
    public GameObject endButton;
    void Start()
    { 
 
        darkBG.SetActive(false);
        darkChar.SetActive(false);
        buttons.SetActive(false);
        backpack.SetActive(false);
    }



    public void TriggerDark()
    {

        darkBG.SetActive(true);
        darkChar.SetActive(true);
        buttons.SetActive(true);
        backpack.SetActive(true);
        endButton.SetActive(false);

}
}
