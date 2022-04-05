using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;

    public bool createMode;
    public GameObject n;
    
    void Start()
    {
    }

    void Update()
    {   
        if(createMode)
        {
            if(Input.GetKeyDown(key))
            Instantiate(n,transform.position,Quaternion.identity);
        }
      
        if(Input.GetKeyDown(key)&&active)
        {
            Destroy(note);
            FindObjectOfType<Score>().AddScore();
            active = false;
        }

        if(Input.GetKeyDown(key)&&!active)
        {
            FindObjectOfType<Score>().SubtractScore();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if(col.gameObject.tag=="Note")
        note = col.gameObject;
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        active = false;

        if(col.gameObject.tag=="Note")
            {
                FindObjectOfType<Score>().SubtractScore();
            }
    }
}


