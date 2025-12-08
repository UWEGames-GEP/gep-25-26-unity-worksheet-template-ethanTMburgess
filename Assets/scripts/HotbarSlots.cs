using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HotbarSlot : MonoBehaviour
{
      public Sprite iconImage;  
    //public Text itemText;

    public void SetItem(ItemObject data)
    {

        if(data == null)
        {
            return;
        }

        if(data.icon == null)
        {
            Clear();
            return;
        }


        gameObject.SetActive(true);
        iconImage = data.icon;     
        GetComponent<Image>().sprite = iconImage;
    }

    public void Clear()
    {
        gameObject.SetActive(false);
    }
    
}