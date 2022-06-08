using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpritesConvo : MonoBehaviour
{
    public DialogueScript dS;
    public GameObject RiverSpeak;
    public GameObject RobinSpeak;
    public GameObject SkylerSpeak;
    // Start is called before the first frame update
    void Start()
    {
        dS = FindObjectOfType<DialogueScript>();
        RiverSpeak.SetActive(false);
        RobinSpeak.SetActive(false);
        SkylerSpeak.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RiverSpeak.SetActive(false);
        RobinSpeak.SetActive(false);
        SkylerSpeak.SetActive(false);
        Debug.Log(dS.nameTag.text);
        if(dS.nameTag.text == "Robin")
        {
            RobinSpeak.SetActive(true);
        }
        else if (dS.nameTag.text == "River")
        {
            RiverSpeak.SetActive(true);
        }
        else if (dS.nameTag.text == "Skyler")
        {
            SkylerSpeak.SetActive(true);
        }

    }
}
