using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class ScriptReader : MonoBehaviour
{
    [SerializeField]
    private TextAsset inkJsonFile;
    private Story storyScript;

    public TMP_Text dialogueText;
    public TMP_Text nameTag;

    void Start()
    {
        LoadStory();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextLine();
        }
    }

    void LoadStory()
    {
        storyScript = new Story(inkJsonFile.text);
        storyScript.BindExternalFunction("Name", (string charName) => ChangeName(charName));
    }

    public void DisplayNextLine()
    {
        if(storyScript.canContinue)
        {
            // Get next storyline
            string text = storyScript.Continue();
            // Remove white space
            text = text?.Trim();
            //Display
            dialogueText.text = text;
        }

        else
        {
            dialogueText.text = "end of this convo";
        }
    }

    public void ChangeName(string name)
    {
        string characterName = name;
        nameTag.text = characterName;

    }
}
