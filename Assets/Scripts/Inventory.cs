using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public Inventory item;
    public Item check;
    public Item check2;
   
    public Button craft;

    //public InventorySlot inventorySlot;
    
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("more than one instance found");
            return;
        }
        instance = this;
    }

    void Start() 
    {
        //inventorySlot = FindObjectOfType<InventorySlot>();
    }

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 10;
    public List<Item> items = new List<Item>();
    
 
    InventorySlot[] slots;
 
    public Toggle[] select;
    public Button button;
  

    void Update()
    {
        if(items.Contains(check) && items.Contains(check2))
            {
               
               
            }  

         for (int i = 0; i < select.Length; i++)
         {
            if (select[i].isOn == true)
            {
                craft.interactable = true;
            }
            else 
            {
                craft.interactable = false;
            }
         }
    }

    public bool Add(Item item)
    {
        if(!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Stop adding stuff!");
                return false;
            }

            items.Add(item);

            if(onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }

        
        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        Debug.Log("aa");

        if(onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
    }
   
}
