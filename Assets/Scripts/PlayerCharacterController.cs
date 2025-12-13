using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class PlayerCharacterController : ThirdPersonController
{
    public GameManager gameManager;

    public void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
           gameManager.NewPause();
        }
    }

    private void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Remove Item");
            GetComponent<Inventory>().itemRemove();
        }
    }
}
