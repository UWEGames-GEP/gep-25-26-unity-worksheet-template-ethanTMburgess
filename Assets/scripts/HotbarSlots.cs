using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HotbarSlot : MonoBehaviour
{
      public Sprite iconImage;  
    //public Text itemText;

    public void SetItem(ItemData data)
    {
        gameObject.SetActive(true);

        iconImage = data.icon;     

        GetComponent<Image>().sprite = iconImage;
    }

    public void Clear()
    {
               
       

        
        gameObject.SetActive(false);
    }
    
}