using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{   
    //This script is used to select an item after minigame is finished

    // Instance of an inventory to reference the function to update the inventory in the main scene
    Inventory inventory;

    //variable to hold the value of a tag of the selected item to make changes in object manager
    public string target;

    //Reference to the offered object
    public GameObject objectHolder;

    void Start() 
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void Update ()
    {
        ClickableMusicBox();
    }

    //To register a hit on the offered object and call a funtion to update the inventory
    public void ClickableMusicBox()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if(hit.collider != null && hit.collider.tag == target)
            {
                inventory.MoveOn(target, objectHolder); 
            }
        }
    }
}
