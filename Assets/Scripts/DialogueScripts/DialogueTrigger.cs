﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private void Awake()
    {
        visualCue.SetActive(true);
    }

    public void TriggerDialogue()
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        visualCue.SetActive(false);
    }
}

