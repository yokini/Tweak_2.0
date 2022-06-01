using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{   

    public Color color;
    public Image icon;
    public Toggle select;
    
    
       void Start()
        {
            select = GetComponent<Toggle>();
            select.onValueChanged.AddListener(OnToggleColorChanged);
            ToggleOff();
        }

        void Update()
        {
            ToggleOn();
        }

        void ToggleOff()
        {   
            GetComponent<Toggle>().enabled = false;
        }

        void ToggleOn()
        {   
            if (icon.enabled == true)
            {
                GetComponent<Toggle>().enabled = true;
            }
        }

        void OnToggleColorChanged(bool isOn)
        {
            if (icon.enabled == true)
            {
                ColorBlock cb = select.colors;
            if (isOn == true)
            {
                cb.normalColor = color;
                cb.highlightedColor = color;
            }
            else
            {
                cb.normalColor = Color.white;
                cb.highlightedColor = Color.white;
            }
            select.colors = cb;
            }
        }


        //move to inventory and use for all children!
        /*public void SelectedItemsButtonEnable()
        { 
            if (icon.enabled == true && select.isOn == true)
            {
                button.interactable = true;
            }

            if (icon.enabled == true && select.isOn == false)
            {
                button.interactable = false;
            }
        }*/

        
}
