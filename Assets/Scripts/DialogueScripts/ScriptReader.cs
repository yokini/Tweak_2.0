﻿using System.Collections;
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

    [SerializeField]
    private GridLayoutGroup choiceHolder;
    [SerializeField]
    private Button choiceBasePrefab;

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

        else if (storyScript.currentChoices.Count>0)
        {
            DisplayChoices();
        }
        else
        {
            dialogueText.text = "End of convo";
        }
    }

    private void DisplayChoices()
    {
        if (choiceHolder.GetComponentsInChildren<Button>().Length > 0) return;

        for (int i = 0; i < storyScript.currentChoices.Count; i++)
        {
            var choice = storyScript.currentChoices[i];
            var button = CreateChoiceButton(choice.text);

            button.onClick.AddListener(() => OnClickChoiceButton(choice));
        }
    }

    Button CreateChoiceButton(string text)
    {

        // Instantiate the Button Prefab
        var choiceButton = Instantiate(choiceBasePrefab);
        choiceButton.transform.SetParent(choiceHolder.transform, false);

        // Change its text
        var buttonText = choiceButton.GetComponentInChildren<TMP_Text>();
        buttonText.text = text;

        return choiceButton;

    }

    void OnClickChoiceButton(Choice choice)
    {
        storyScript.ChooseChoiceIndex(choice.index);
        RefreshChoiceView();

        DisplayNextLine();
    }

    void RefreshChoiceView()
    {
        if (choiceHolder != null)
        {
            foreach(var button in choiceHolder.GetComponentsInChildren<Button>())
            {
                Destroy(button.gameObject);
            }
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
