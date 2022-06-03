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

    //public Image characterIcon;
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
        //storyScript.BindExternalFunction("Icon", (string charName) => ChangeCharacterIcon(charName));
        storyScript.BindExternalFunction("CharAnimation", (string charName, string animName) => playCharacterAnim(charName, animName));
        DisplayNextLine();

     

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
            dialogueText.text = "end convo";
        }
    }

    public void ChangeName(string name)
    {
        string characterName = name;
        nameTag.text = characterName;

    }

    //public void ChangeCharacterIcon(string name)
    //{
    //    var charIcon = Resources.Load<Sprite>("charactericons/" + name);
    //    characterIcon.sprite = charIcon;
    // }

    public void playCharacterAnim(string charName, string animName)
    {
        GameObject character = GameObject.Find(charName);
        character.GetComponent<CharacterAnimation>().CharacterAnimations(animName);
    }

}
