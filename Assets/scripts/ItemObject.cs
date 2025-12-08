using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public string itemName;
    public Sprite icon;
    public GameObject itemPrefab;


     void Start() {
        {
            if (itemPrefab == null)
            {
                itemPrefab = gameObject;
            }


            if (string.IsNullOrEmpty(itemName))
            {
                itemName = gameObject.name;
            }
        }
    }
}
