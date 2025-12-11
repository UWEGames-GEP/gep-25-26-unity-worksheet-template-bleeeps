using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void itemAdd(string item)
    {
        items.Add(item);
    }

    public void itemRemove(string item)
    {
        items.Remove(item);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
