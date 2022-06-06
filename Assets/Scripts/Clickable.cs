using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    Inventory inventory;
    public string Target;

    void Start() 
    {
        inventory = FindObjectOfType<Inventory>();
    }

    void Update ()
    {
        ClickableMusicBox();
    }

    public void ClickableMusicBox()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if(hit.collider != null && hit.collider.tag == Target)
            {
                inventory.JustMoveOnMusicBox();   
            }
        }
    }

    


}
