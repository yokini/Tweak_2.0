using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    //This script is atached to the activators which activate when a note collides and destroys it on button press
    public KeyCode key;
    bool active = false;
    GameObject note;

    public bool createMode;
    public GameObject n;
    
    void Update()
    {   
        //CreatMode is used to instantiate notes from the activators
        if(createMode)
        {
            if(Input.GetKeyDown(key))
            Instantiate(n,transform.position,Quaternion.identity);
        }
      
        //Destroys the note and checks if the activator was activated when it happened. Score update (+)
        if(Input.GetKeyDown(key)&&active)
        {
            Destroy(note);
            FindObjectOfType<ScoreRobin>().AddScore();
            active = false;
        }

        //If the activator is not activated it had to update score (-)
        if(Input.GetKeyDown(key)&&!active)
        {
            FindObjectOfType<ScoreRobin>().SubtractScore();
        }
    }

    //When it collides with the note the activator activates
    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        if(col.gameObject.tag=="Note")
        note = col.gameObject;
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        active = false;

        //It updates the score if the note is not destroyed
        if(col.gameObject.tag=="Note")
            {
                FindObjectOfType<ScoreRobin>().SubtractScore();
            }
    }
}


