using UnityEngine;

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