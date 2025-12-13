using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<ItemObject> items = new List<ItemObject>();

    GameManager gameManager;
    Transform worldItemsTransform;

    public void itemAdd(ItemObject item)
    {
        items.Add(item);
    }

    public void itemRemove(ItemObject item)
    {
       Vector3 currentPosition = worldItemsTransform.position;
       Vector3 forward = worldItemsTransform.forward;

       Vector3 newPosition = currentPosition + forward;
       newPosition += new Vector3(0, 1, 0);

       Quaternion currentRotation = worldItemsTransform.rotation;
       Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 100);

       GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, worldItemsTransform);
       newItem.SetActive(true);

       items.Remove(item);
        Destroy(item.gameObject);
    }

    public void itemRemove()
    {
        if(gameManager.state == GameManager.GameState.GAMEPLAY && items.Count > 0)
        {
            ItemObject item = items[0];

            itemRemove(item);
        }
    }

    public void itemRemove(int i)
    {
        if(i < items.Count)
        {
            itemRemove(items[i]);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        if (collisionItem != null)
        {
            items.Add(collisionItem);
            collisionItem.gameObject.SetActive(false);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

        worldItemsTransform = GameObject.Find("ItemParent").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
            //itemAdd("Generic Item");
        //}
       // if (Input.GetKeyDown(KeyCode.Alpha2))
       // {
            //itemRemove("Generic Item");
        //}
    }
}
