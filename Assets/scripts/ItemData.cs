using UnityEngine;

[System.Serializable]
public class ItemData
{
    public string itemName;
    public Sprite icon;

    public ItemData(string name, Sprite sprite)
    {
        itemName = name;
        icon = sprite;
    }
}