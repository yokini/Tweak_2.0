using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUI : MonoBehaviour
{
    //Thid is scripts displays the data referenced in scriptable object

    //Reference to the object
    public Object Object;
    //Name of the object
    public Text objectName;
    //Image of the object;
    public Image objectImage;
    void Start()
    {   
        //Sets the UI according to the information collected from scriptable object
        objectName.text = Object.name;

        objectImage.sprite = Object.icon;
        
    }

    
}
