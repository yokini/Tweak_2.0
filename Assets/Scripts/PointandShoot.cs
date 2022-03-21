using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointandShoot : MonoBehaviour
{   
    public GameObject crossHair;
    private Vector2 target;
    
    void Start()
    {
        Cursor.visible = false;   
    }

    // Update is called once per frame
    void Update()
    {
       target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
       crossHair.transform.position = new Vector2(target.x, target.y);

        

        

       
    }

}
