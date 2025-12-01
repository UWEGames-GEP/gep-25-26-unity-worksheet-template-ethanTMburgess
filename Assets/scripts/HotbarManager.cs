using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HotbarManager : MonoBehaviour
{
    public inventory playerInventory;
    public List<HotbarSlot> slots = new List<HotbarSlot>();

    void Start()
    {
        playerInventory = FindAnyObjectByType<inventory>();
    }

    void Update()
    {
        if (playerInventory == null) return;

        
        foreach (var slot in slots)
            slot.Clear();

        
        for (int i = 0; i < playerInventory.items.Count && i < slots.Count; i++)
        {
            slots[i].SetItem(playerInventory.items[i]);
            
        
             //slots[i].SetItem(playerInventory.items[i].name);
        }
    }
}