using UnityEngine;
using System.Collections.Generic;

public class inventory : MonoBehaviour
{
    public GameManager gameManager;
    public List<ItemObject> items = new List<ItemObject>();
    
    [Header("References")]
    [SerializeField] private Transform worldItemsTransform; 

    [Header("Object Drop Distance")]
    [SerializeField] private float dropDistance = 2f;


    
    public void addItemToInventory(ItemObject item)
    {
        items.Add(item);
        Debug.Log("Added " + item.itemName + " to inventory");
    }
    


    public void removeItemFromInventory(ItemObject item)
    {
        if(items.Count == 0)
            return;

        ItemObject first = items[0];

        if (items.Count == 0)
        {
            return;
        }

        if(!items.Contains(item))
        {
            Debug.Log ("Item not found in inv" + item.itemName);
            return;
        }

        if(worldItemsTransform == null)
        {
            GameObject worldItems = GameObject.Find("WorldItems");
            if(worldItems == null)
            {
                worldItems = new GameObject("WorldItems");
                worldItems.transform.parent = null;
                Debug.Log("Created WorldItems GameObject");
            }
            worldItemsTransform = worldItems.transform;
        }

        Vector3 dropPosition = transform.position + transform.forward * dropDistance;
        dropPosition.y = transform.position.y + 1 ;

        Vector3 pos = transform.position + transform.forward;
        


        if(item.itemPrefab == null)
        {
            Debug.Log("Item Prefab is null for " + item.itemName);

            items.Remove(item);
            return;
        }
        GameObject newItem = Instantiate(item.itemPrefab, dropPosition, Quaternion.identity);
        newItem.SetActive(true);

        //first.gameObject.SetActive(false);

        items.Remove(item);
        Debug.Log("Removed " + item.itemName + " from inventory");
    }

    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        
        // Try to find WorldItems
        GameObject worldItems = GameObject.Find("WorldItems");
        if (worldItems != null)
        {
            worldItemsTransform = worldItems.transform;
        }
        else
        {
           
            Debug.LogWarning("WorldItems GameObject not found");
        }
    }


 public void removeFirstItem()
    {
        if(items.Count == 0)
        {
            Debug.Log("Inventory is empty!");
            return;
        }

        ItemObject firstItem = items[0];
        if(firstItem == null)
        {
            Debug.Log("first item in inv is null. removed");
            items.RemoveAt(0);
            return;
        }
        removeItemFromInventory(firstItem);
    }

     void Update() {
        {
            worldItemsTransform.parent = null;

            if(Input.GetKeyDown(KeyCode.Q))
            {
                removeFirstItem();
            }
        }
    }
}