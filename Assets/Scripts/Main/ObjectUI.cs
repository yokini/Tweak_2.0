using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUI : MonoBehaviour
{
    public Object Object;

    public Text objectName;

    public Image objectImage;
    void Start()
    {
        objectName.text = Object.name;

        objectImage.sprite = Object.icon;
        
    }

    
}
