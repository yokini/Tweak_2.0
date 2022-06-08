using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    // Declaring variables for the gameObjects in the scene
    public GameObject EndButton;
    public GameObject ConvoButton;
    public GameObject ConvoUI;
    public GameObject ConvoManager;

    void Start()
    {
        // only the start convo button visible
        EndButton.SetActive(false);
        ConvoUI.SetActive(false);
        ConvoManager.SetActive(false);
        ConvoButton.SetActive(true);
    }

    public void EndConvo()
    {
        //Emd Convo button visible
        EndButton.SetActive(true);
    }

    public void StartConversation()
    {
        // Dialogue UI pops up when start convo button is pressed
        ConvoUI.SetActive(true);
        ConvoManager.SetActive(true);
        ConvoButton.SetActive(false);

    }
}
