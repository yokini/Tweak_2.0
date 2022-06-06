using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationScript : MonoBehaviour
{
    public Animator charAnimController;

    private void Start()
    {
        charAnimController = GetComponent<Animator>();
    }
    public void CharacterAnimations(string animationName)
    {
        charAnimController.SetTrigger(animationName);
    }
}
