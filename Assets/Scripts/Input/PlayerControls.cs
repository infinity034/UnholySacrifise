//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/Input/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9ed70b72-9e50-4db1-82cc-1f4fcbab8845"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2d8045af-4e19-40f5-9d54-14c49b1463e4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9cccce78-8721-4005-a392-0438bab6cdde"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 0"",
                    ""type"": ""Button"",
                    ""id"": ""06feddd0-420d-4dec-884d-81f00aaf79b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 1"",
                    ""type"": ""Button"",
                    ""id"": ""52930d22-47d2-43ce-a180-3742770bb654"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 2"",
                    ""type"": ""Button"",
                    ""id"": ""37dda00f-68d8-4964-b80c-d29440bae347"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 3"",
                    ""type"": ""Button"",
                    ""id"": ""fd6bd370-d19d-44a9-a1e1-fe119c8edeee"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 4"",
                    ""type"": ""Button"",
                    ""id"": ""99d39487-732e-453c-b4c9-7a8a3979456f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 5"",
                    ""type"": ""Button"",
                    ""id"": ""577f5cb9-98cc-468f-91d6-059dbf90ab1b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 6"",
                    ""type"": ""Button"",
                    ""id"": ""1adce627-411c-461d-b72c-3022fdfb10b8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slot 7"",
                    ""type"": ""Button"",
                    ""id"": ""0488271d-b0bb-43ce-9e55-7a9bb6e9e875"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""ff993494-d6ad-47c9-a875-0c975fee81ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""920ed1c9-23f5-4fa5-a20e-3bad4eb17bbc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""49bd8e55-5bb9-4c74-a284-d5bc2079682d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3d4f2112-1998-45c6-8910-e0f5f6088075"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5438d727-0ea7-4367-8a02-b5ef9bf0b266"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7bd39456-884c-4a5c-a816-d0c02b81f62e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c88066cd-bf88-4359-97f9-fd5c29970621"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c29547ce-1fd0-47d6-894f-60ca2f057467"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd14896b-1f7b-4ebf-b95a-2de629bcc86c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d48cf08-91f8-42eb-9a76-74b7c26fe0c5"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b35f33a3-9de0-4ad9-be9d-8367e73b85d1"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe07e09f-8ee6-4cfd-993b-fd41e91c9b78"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6731003-d0e6-4c28-aa52-e2e06a7ad05f"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a921c2d1-7f1c-4283-b229-25cb1f27a282"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""620cdf5e-134a-4ca5-969e-93330f863ff7"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a024d40-bc9d-42af-a2be-91a3c5c7b367"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slot 7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""837ac452-9fd5-4129-955b-93a4dffab698"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f28554d-7ca5-4bb6-82c5-29ecdaeb0ecd"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78fc37ca-69df-4b62-9cd9-833232dcee03"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Slot0 = m_Player.FindAction("Slot 0", throwIfNotFound: true);
        m_Player_Slot1 = m_Player.FindAction("Slot 1", throwIfNotFound: true);
        m_Player_Slot2 = m_Player.FindAction("Slot 2", throwIfNotFound: true);
        m_Player_Slot3 = m_Player.FindAction("Slot 3", throwIfNotFound: true);
        m_Player_Slot4 = m_Player.FindAction("Slot 4", throwIfNotFound: true);
        m_Player_Slot5 = m_Player.FindAction("Slot 5", throwIfNotFound: true);
        m_Player_Slot6 = m_Player.FindAction("Slot 6", throwIfNotFound: true);
        m_Player_Slot7 = m_Player.FindAction("Slot 7", throwIfNotFound: true);
        m_Player_Mouse = m_Player.FindAction("Mouse", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, PlayerControls.Player.Disable() has not been called.");
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Slot0;
    private readonly InputAction m_Player_Slot1;
    private readonly InputAction m_Player_Slot2;
    private readonly InputAction m_Player_Slot3;
    private readonly InputAction m_Player_Slot4;
    private readonly InputAction m_Player_Slot5;
    private readonly InputAction m_Player_Slot6;
    private readonly InputAction m_Player_Slot7;
    private readonly InputAction m_Player_Mouse;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Slot0 => m_Wrapper.m_Player_Slot0;
        public InputAction @Slot1 => m_Wrapper.m_Player_Slot1;
        public InputAction @Slot2 => m_Wrapper.m_Player_Slot2;
        public InputAction @Slot3 => m_Wrapper.m_Player_Slot3;
        public InputAction @Slot4 => m_Wrapper.m_Player_Slot4;
        public InputAction @Slot5 => m_Wrapper.m_Player_Slot5;
        public InputAction @Slot6 => m_Wrapper.m_Player_Slot6;
        public InputAction @Slot7 => m_Wrapper.m_Player_Slot7;
        public InputAction @Mouse => m_Wrapper.m_Player_Mouse;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Slot0.started += instance.OnSlot0;
            @Slot0.performed += instance.OnSlot0;
            @Slot0.canceled += instance.OnSlot0;
            @Slot1.started += instance.OnSlot1;
            @Slot1.performed += instance.OnSlot1;
            @Slot1.canceled += instance.OnSlot1;
            @Slot2.started += instance.OnSlot2;
            @Slot2.performed += instance.OnSlot2;
            @Slot2.canceled += instance.OnSlot2;
            @Slot3.started += instance.OnSlot3;
            @Slot3.performed += instance.OnSlot3;
            @Slot3.canceled += instance.OnSlot3;
            @Slot4.started += instance.OnSlot4;
            @Slot4.performed += instance.OnSlot4;
            @Slot4.canceled += instance.OnSlot4;
            @Slot5.started += instance.OnSlot5;
            @Slot5.performed += instance.OnSlot5;
            @Slot5.canceled += instance.OnSlot5;
            @Slot6.started += instance.OnSlot6;
            @Slot6.performed += instance.OnSlot6;
            @Slot6.canceled += instance.OnSlot6;
            @Slot7.started += instance.OnSlot7;
            @Slot7.performed += instance.OnSlot7;
            @Slot7.canceled += instance.OnSlot7;
            @Mouse.started += instance.OnMouse;
            @Mouse.performed += instance.OnMouse;
            @Mouse.canceled += instance.OnMouse;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Slot0.started -= instance.OnSlot0;
            @Slot0.performed -= instance.OnSlot0;
            @Slot0.canceled -= instance.OnSlot0;
            @Slot1.started -= instance.OnSlot1;
            @Slot1.performed -= instance.OnSlot1;
            @Slot1.canceled -= instance.OnSlot1;
            @Slot2.started -= instance.OnSlot2;
            @Slot2.performed -= instance.OnSlot2;
            @Slot2.canceled -= instance.OnSlot2;
            @Slot3.started -= instance.OnSlot3;
            @Slot3.performed -= instance.OnSlot3;
            @Slot3.canceled -= instance.OnSlot3;
            @Slot4.started -= instance.OnSlot4;
            @Slot4.performed -= instance.OnSlot4;
            @Slot4.canceled -= instance.OnSlot4;
            @Slot5.started -= instance.OnSlot5;
            @Slot5.performed -= instance.OnSlot5;
            @Slot5.canceled -= instance.OnSlot5;
            @Slot6.started -= instance.OnSlot6;
            @Slot6.performed -= instance.OnSlot6;
            @Slot6.canceled -= instance.OnSlot6;
            @Slot7.started -= instance.OnSlot7;
            @Slot7.performed -= instance.OnSlot7;
            @Slot7.canceled -= instance.OnSlot7;
            @Mouse.started -= instance.OnMouse;
            @Mouse.performed -= instance.OnMouse;
            @Mouse.canceled -= instance.OnMouse;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSlot0(InputAction.CallbackContext context);
        void OnSlot1(InputAction.CallbackContext context);
        void OnSlot2(InputAction.CallbackContext context);
        void OnSlot3(InputAction.CallbackContext context);
        void OnSlot4(InputAction.CallbackContext context);
        void OnSlot5(InputAction.CallbackContext context);
        void OnSlot6(InputAction.CallbackContext context);
        void OnSlot7(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
