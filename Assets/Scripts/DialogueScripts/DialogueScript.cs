using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class DialogueScript : MonoBehaviour
{
    //This Script is for the Dialogue Manager
    // Declaring Variables
    [SerializeField]
    private TextAsset inkJsonFile;
    private Story storyScript;

    // Text Files
    public TMP_Text dialogueText;
    public TMP_Text nameTag;

    // Choice Buttons and Arrangement
    [SerializeField]
    private GridLayoutGroup choiceHolder;
    [SerializeField]
    private Button choiceBasePrefab;

    //To Trigger the Dialogue
    public UIManagerScript UIScript;

    //UI
    public GameObject DialogueBox;


    void Start()
    {
        //Referencinbg
        UIScript = FindObjectOfType<UIManagerScript>();
        // Dialogue box is active
        DialogueBox.SetActive(true);
        // Start the conversation
        LoadStory();
    }

    // start convo
    void LoadStory()
    {
        // link to ink Json file get contents
        storyScript = new Story(inkJsonFile.text);
        //Getting the name of the character speaking from the Json file
        storyScript.BindExternalFunction("Name", (string charName) => ChangeName(charName));
        //keep convo going
        DisplayNextLine();

    }

    // keep convo going
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
        // trigger choices
        else if (storyScript.currentChoices.Count>0)
        {
            DisplayChoices();
        }
        //Close when conversation is done
        //Call EndConvo(); from UI Script 
        else
        {
            DialogueBox.SetActive(false);
            //nameTag.text = null;
            //dialogueText.text = null;
            UIScript.EndConvo();
        }
    }

    //Displaying choices
    private void DisplayChoices()
    {
        // Figuring out how many choices there are and instantiating the required number of buttons
        if (choiceHolder.GetComponentsInChildren<Button>().Length > 0) return;

        for (int i = 0; i < storyScript.currentChoices.Count; i++)
        {
            var choice = storyScript.currentChoices[i];
            var button = CreateChoiceButton(choice.text);

            button.onClick.AddListener(() => OnClickChoiceButton(choice));
        }
    }

    //creating the buttons
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

    //refresh on making a decision, and proceeding with the conversation
    void OnClickChoiceButton(Choice choice)
    {
        storyScript.ChooseChoiceIndex(choice.index);
        RefreshChoiceView();

        DisplayNextLine();
    }

    // Destroying buttons
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

    // Assigning the name from the Json File to the NameTag, to be displayed
    public void ChangeName(string name)
    {
        string characterName = name;
        nameTag.text = characterName;

    }

}
