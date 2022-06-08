using UnityEngine;

//Scriptable object to create a template for objects player can collect in minigames

[CreateAssetMenu(fileName = "New Object", menuName = "Inventory/Object")]
public class Object : ScriptableObject
{
  new public string name = "New Object";
  public Sprite icon = null;
 
  public virtual void Use()
  {
      Debug.Log("using " + name);
  }
}