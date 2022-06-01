using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    Item item;
    public Button craft;

    List<Item> removeItems = new List<Item>();


    void Update()
    {
     removeItems = Inventory.instance.items;   
    }

    public void AddItem (Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
    }

   

    public void ClearSlot()
    {
       
       
        item = null;
        Debug.Log("The item was removed");
       icon.sprite = null;
       icon.enabled = false;
        
    }

    public void OnRemoveButton()
    {
        //clearItems = removeItems;
        //Debug.Log("clearitems were set to removeitems");
        Debug.Log("DHSAUFHSD");
        Inventory.instance.Remove(item);
    }
}
