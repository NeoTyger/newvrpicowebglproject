using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MyInteractable : XRBaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
        action.started += PrintMesagge; // Button Pressed
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

    [Header("Input Action")] public InputAction action = null;
    
    public void PrintMesagge(InputAction.CallbackContext context)
    {
        if (base.isHovered)
        {
           Debug.Log("activated"); 
        }
    }
}
