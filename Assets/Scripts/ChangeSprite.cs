using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{   
    Camera cam;
    public Sprite[] spriteList;
    public int currentSprite;
    public string Target;
    public Item item;
   
   
    public SpriteRenderer spriteRenderer;


    void Start()
    {
       spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
       cam = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
 
            if(hit.collider != null && hit.collider.tag == Target)
            {
                Debug.Log ("Target name: " + hit.collider.name);   
                ClickChangeSprite();
            }
        }


        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
 
            if(hit.collider != null && hit.collider.tag == Target && currentSprite == spriteList.Length)
            {
                Debug.Log ("Target name: " + hit.collider.name);
               
                PickUpItem();
            }
        }
    }

    void ClickChangeSprite()
    {   
        spriteRenderer.sprite = spriteList[currentSprite];
        currentSprite++;

        Debug.Log("hithit");
    }

    void ClickPickUp()
    {
       //to clean up the script!
    }

    public void PickUpItem()
    {
        Debug.Log("Picked up item" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
            Destroy(gameObject);
    }

}
