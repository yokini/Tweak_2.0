using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScenes : MonoBehaviour
{ 
    public void EndingScenes() 
    {
        if (ObjectManager.instance.robinObject && ObjectManager.instance.riverObject && ObjectManager.instance.skylerObject) 
        {
            SceneManager.LoadScene(14);
        }

        else if ((ObjectManager.instance.robinObject && ObjectManager.instance.riverObject) || (ObjectManager.instance.robinObject && ObjectManager.instance.skylerObject) || (ObjectManager.instance.riverObject && ObjectManager.instance.skylerObject) ) 
        {
            SceneManager.LoadScene(15);
        }

        else if (ObjectManager.instance.robinObject || ObjectManager.instance.riverObject || ObjectManager.instance.skylerObject) 
        {
            SceneManager.LoadScene(16);
        }

        else if (!ObjectManager.instance.robinObject || ! ObjectManager.instance.riverObject || !ObjectManager.instance.skylerObject) 
        {
            SceneManager.LoadScene(17);
        }
    }
}
