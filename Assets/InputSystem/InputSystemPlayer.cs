//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/InputSystem/InputSystemPlayer.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystemPlayer : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemPlayer()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemPlayer"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0bc20195-410e-4ef9-b111-95b3eaf76dec"",
            ""actions"": [
                {
                    ""name"": ""Moverse"",
                    ""type"": ""Value"",
                    ""id"": ""7cbfa4c3-6373-430a-9a03-450a25f5fc73"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Saltar"",
                    ""type"": ""Button"",
                    ""id"": ""f5d1ccfb-d87b-4bbd-b865-da0dc551ef4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FreeLookView"",
                    ""type"": ""Value"",
                    ""id"": ""5be87cd1-f254-481d-86b9-c40ae7c36fc0"",
                    ""expectedControlType"": ""Delta"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ab45ad05-1277-4348-b773-9f3a7fc81927"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5a324f7c-cc92-4372-8d2c-e8bed3954c46"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3d4ffda9-b0f0-4245-ab8c-f54c611e8fad"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""64f540a4-568e-4afb-bd07-d47caa87c71a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""749df5ea-3271-4044-aa05-f859c2fafae8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""fc611a2e-0c35-497b-b5c7-6b48f5be298e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e0595619-d370-4433-86ac-a52d34c2c05e"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""613acf08-c77b-4384-8374-2fcd1266ec2e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f7352f55-9dd6-4610-9128-d5ca0d781b3c"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dfec9e56-2729-4858-aa2f-333ae5fd0043"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ddf4ba8e-7223-4b79-85b3-37dda63efa8e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef63cfd1-4b40-44b7-b908-de97c95b1288"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FreeLookView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Moverse = m_Player.FindAction("Moverse", throwIfNotFound: true);
        m_Player_Saltar = m_Player.FindAction("Saltar", throwIfNotFound: true);
        m_Player_FreeLookView = m_Player.FindAction("FreeLookView", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Moverse;
    private readonly InputAction m_Player_Saltar;
    private readonly InputAction m_Player_FreeLookView;
    public struct PlayerActions
    {
        private @InputSystemPlayer m_Wrapper;
        public PlayerActions(@InputSystemPlayer wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moverse => m_Wrapper.m_Player_Moverse;
        public InputAction @Saltar => m_Wrapper.m_Player_Saltar;
        public InputAction @FreeLookView => m_Wrapper.m_Player_FreeLookView;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Moverse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoverse;
                @Saltar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaltar;
                @Saltar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaltar;
                @Saltar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaltar;
                @FreeLookView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeLookView;
                @FreeLookView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeLookView;
                @FreeLookView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFreeLookView;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @Saltar.started += instance.OnSaltar;
                @Saltar.performed += instance.OnSaltar;
                @Saltar.canceled += instance.OnSaltar;
                @FreeLookView.started += instance.OnFreeLookView;
                @FreeLookView.performed += instance.OnFreeLookView;
                @FreeLookView.canceled += instance.OnFreeLookView;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoverse(InputAction.CallbackContext context);
        void OnSaltar(InputAction.CallbackContext context);
        void OnFreeLookView(InputAction.CallbackContext context);
    }
}
