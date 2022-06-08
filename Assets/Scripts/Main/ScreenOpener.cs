using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOpener : MonoBehaviour
{
    //This screen sets active canvases in the main scene
    
   public GameObject PanelOpen;
   public GameObject PanelClose;

   public void OpenScreen ()
   {
       if (PanelOpen != null)
       {
           PanelOpen.SetActive(true);
       }
   }

   public void CloseScreen ()
   {
       if (PanelClose != null)
       {
           PanelClose.SetActive(false);
       }
   }
}
