using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, InputSystemPlayer.IPlayerActions
{
    public static InputManager Instance { get; private set; }
    public Vector2 Movement { get; private set;}

    private InputSystemPlayer mInputPlayer;
    private event EventHandler OnJumpHandler;

    void Awake()
    {
        Instance = this;

        mInputPlayer = new InputSystemPlayer();
        mInputPlayer.Player.SetCallbacks(this);
    }

    void OnEnable()
    {
        mInputPlayer.Enable();
    }

    void OnDisable()
    {
        mInputPlayer.Disable();
    }

    public void OnMoverse(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnSaltar(InputAction.CallbackContext context)
    {
        OnJumpHandler?.Invoke(this, EventArgs.Empty);
    }

    public void AddOnJumpHandler(EventHandler handler)
    {
        OnJumpHandler += handler;
    }

    public void OnFreeLookView(InputAction.CallbackContext context)
    {}
}
