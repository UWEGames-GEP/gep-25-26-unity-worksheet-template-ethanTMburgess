using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;


public class Collect : MonoBehaviour
{
    
    public string itemName = "Diamond";
    public Sprite icon;

   private void OnTriggerEnter(Collider other) {

    inventory playerInventory = other.GetComponent <inventory>();

    if(playerInventory != null)
    {
        playerInventory.addItemToInventory(itemName, icon);
        Destroy(gameObject);
    }
   }


    
}
