using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    bool go;

    public GameObject player;
    public GameObject boomerang;

    Transform itemRotate;

    public float throwSpeed = 5f;

    Vector3 locationInFrontOfPlayer;

    Vector3 locationInSideOfPlayer;

    Vector3 locationOfPlayer;

    Vector3 mousePosition;

    // Start is called before the first frame update
    async void Start()
    {
        go = false;

        itemRotate = gameObject.transform;

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        locationInFrontOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y, 0) + mousePosition * throwSpeed;
       

        locationOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y, 0);

        

        

        StartCoroutine(Boom());
        
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
        

        itemRotate.transform.Rotate(0, 0, Time.deltaTime * 2000);

        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationInFrontOfPlayer, Time.deltaTime * 20);
        }

        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationOfPlayer, Time.deltaTime * 20);
        }

        if (!go && Vector3.Distance(player.transform.position, transform.position) < 2)
        {
            Destroy(this.gameObject);
        }
        
    }
}
