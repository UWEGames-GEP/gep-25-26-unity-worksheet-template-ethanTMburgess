using UnityEngine;
using System.Collections.Generic;


public class inventory : MonoBehaviour
{
    // calls an object of the Game Manager script
    public GameManager gameManager;

  //  public List<string> items = new List <string>();

   public List<ItemData> items = new List<ItemData>();

   public void addItemToInventory(string itemName, Sprite icon)
    {
        items.Add(new ItemData(itemName, icon));
    }
    
   public void removeItemFromInventory(string itemName)
    {
        items.RemoveAll(i => i.itemName == itemName);
    }
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the Game Manager and refernce it to populate gameManager Object
        gameManager = FindAnyObjectByType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(gameManager.state == GameManager.GameState.GAMEPLAY)
        {
            
            
           if (Input.GetKeyDown(KeyCode.Alpha1)) 
            {
            addItemToInventory("Generic Item", null);  
            }
            
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                removeItemFromInventory("Generic Item");
            }
            

        }
        
    }

    
    
}
