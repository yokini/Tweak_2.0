using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{   public GameObject key;


   void Update ()
     {
         if(Input.GetKey(KeyCode.Tab))
         {
            gameObject.SetActive(key);
         }

     }
}
