using UnityEngine;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();

    private void OnEnable()
    {
        RefreshInventory();
    }

    void RefreshInventory()
    {
        Debug.Log("Refresh Inventory UI");

        foreach(GameObject uiButton in inventoryUIButtons)
        {
            uiButton.SetActive(false);
        }

        for(int i = 0; i < inventory.items.Count; i++)
        {
            if(i < inventoryUIButtons.Count)
            {
                PressableButtons uiButton = inventoryUIButtons[i].GetComponent<PressableButtons>();
                ItemObject item = inventory.items[i];

                uiButton.gameObject.SetActive(true);
                uiButton.SetButton(item);
            }
        }
    }

    public void OnInventoryUIButton(int i)
    {
        inventory.itemRemove(i);
        RefreshInventory();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
