using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartExtra : MonoBehaviour
{   
    //Sets up button behavior on click
    public Image aboutGame;

    public void ChangeSceneStart()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeSpriteExtra()
    {
        aboutGame.gameObject.SetActive(true);
    }

    public void ChangeSpriteMenu()
    {
        aboutGame.gameObject.SetActive(false);
    }
}
