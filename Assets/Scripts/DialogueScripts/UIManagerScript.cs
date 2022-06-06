using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public GameObject EndButton;
    public GameObject ConvoButton;
    public GameObject ConvoUI;
    public GameObject ConvoManager;


    // Start is called before the first frame update
    void Start()
    {
        EndButton.SetActive(false);
        ConvoUI.SetActive(false);
        ConvoManager.SetActive(false);
        ConvoButton.SetActive(true);
    }

    public void EndConvo()
    {
        EndButton.SetActive(true);
    }

    public void StartConversation()
    {
        ConvoUI.SetActive(true);
        ConvoManager.SetActive(true);
        ConvoButton.SetActive(false);

    }
}
