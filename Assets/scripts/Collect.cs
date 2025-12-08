using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


public class Collect : MonoBehaviour
{
    
    public inventory playerInventory;
    

   private void OnTriggerEnter(Collider other) {

    Debug.Log("Collided with item");

    inventory playerInventory = other.GetComponent <inventory>();
    ItemObject item = GetComponent<ItemObject>();

    if(playerInventory != null)
    {

       
        playerInventory.addItemToInventory(item);
        
        gameObject.SetActive(false);
       
        
        //Destroy(gameObject);
    }

   }

   
    
}



