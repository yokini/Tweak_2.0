using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    //This script does not allow the player to go outside the screen

    //Reference to the screenbound
    private Vector2 screenBounds;

    //Maximum values player can go in any direction
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        //Clamp the gameobject within its current position and maximum values in x and y axix
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
    }
}
