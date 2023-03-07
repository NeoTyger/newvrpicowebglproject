using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MyInteractable : XRBaseInteractable
{
    
    [Header("Input Action")] public InputAction action = null;

    protected override void Awake()
    {
        base.Awake();
        action.started += ButtonPressedAction; // Button Pressed
        // action.canceled += // Button Release
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        action.Enable();
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        action.Disable();
    }

    public void ButtonPressedAction(InputAction.CallbackContext context)
    {
        if (base.isHovered)
        {
            GetComponent<PlaceHolderChecker>().ObjectsInPedestalsChecker();
        }
    }
}
