using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    public GameManager gameManager;

    public void itemAdd(string item)
    {
        items.Add(item);
    }

    public void itemRemove(string item)
    {
        items.Remove(item);
    }

    public void OnControllerColliderHit()
    {
        ItemObject collisionItem = OnControllerColliderHit().gameObject.GetComponent<ItemObject>();

        if (collisionItem != null)
        {
            items.Add(collisionItem.name);
        }

        Destroy(collisionItem.name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            itemAdd("Generic Item");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            itemRemove("Generic Item");
        }
    }
}
