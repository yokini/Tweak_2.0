using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    bool go;

    public GameObject player;
    public GameObject boomerang;
    private Vector2 screenBound;

    public float maximumDistance = Screen.height;

    public float rotationSpeed = 2000f;

    Transform itemRotate;

    public float throwSpeed = 5f;

    Vector3 locationInFrontOfPlayer;

    Vector3 locationOfPlayer;

    Vector3 mousePosition;

    Camera cam;




    
    void Start()
    {
        go = false;

        itemRotate = gameObject.transform;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));

        locationInFrontOfPlayer =  mousePosition * throwSpeed;
       

        locationOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y, 0);

        screenBound = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z ));

        
        

        

        if (Input.GetMouseButtonDown(0)) 
        {
            StartCoroutine(Boom());

            Debug.Log("Clicked " + mousePosition);
        }

        
        
    }

    IEnumerator Boom()
    {
        go = true;

        yield return new WaitForSeconds(1/2f);

        go = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        itemRotate.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.MoveTowards(transform.position, locationInFrontOfPlayer, maximumDistance * Time.deltaTime);
        }

        /*if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationInFrontOfPlayer, maximumDistance * Time.deltaTime);
        }

        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationOfPlayer, maximumDistance * Time.deltaTime);
        }

        if (!go && Vector3.Distance(player.transform.position, transform.position) < 1/2)
        {
            Destroy(this.gameObject);
        }*/

        
        
    }

   
}
