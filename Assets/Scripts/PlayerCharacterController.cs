using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{
    public GameManager gameManager;

    private void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
           gameManager.NewPause();
        }
    }

    //private void OnRemoveItem(InputValue value)
    //{
        //if (value.isPressed)
        //{
            //Debug.Log("Remove Item");
            //GetComponent<Inventory>().RemoveItemFromInventory();
        //}
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
