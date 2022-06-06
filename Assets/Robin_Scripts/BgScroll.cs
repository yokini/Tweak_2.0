using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{   public float speed = 4f;

    public float maximumHeight = 15f;

    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.y > maximumHeight)
        {
            transform.position = startPosition;
        }


        
    }
}
