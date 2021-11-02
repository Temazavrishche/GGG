// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6f671d67-609b-4100-a50e-fdb24edae182"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1bd84c6a-e334-4dae-8806-e96349aee1d9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f8d967d3-0cb4-44df-b3f9-3b336b67ea58"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""93c91b55-d539-4f70-a046-e38791761194"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""f5f3159d-16ba-4bed-9621-8558c9e13475"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""3897b3e2-195d-449a-9563-f6ecdf5830b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseqAbility"",
                    ""type"": ""Value"",
                    ""id"": ""51292517-9dc4-4f5b-af65-2f1076e92be7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseeAbility"",
                    ""type"": ""Value"",
                    ""id"": ""2331224a-4132-4bf0-9abd-17019cc3103b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UserAbility"",
                    ""type"": ""Value"",
                    ""id"": ""3e1262e4-5e91-4d4a-b407-26203520f430"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UsefAbility"",
                    ""type"": ""Value"",
                    ""id"": ""3ad06a9a-6474-405d-9670-fa203185de80"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectFirstSlot"",
                    ""type"": ""Button"",
                    ""id"": ""f5f53bd3-9693-4324-816c-9271c7e8774a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectSecondSlot"",
                    ""type"": ""Button"",
                    ""id"": ""fb06a8b4-565c-4a93-a05e-13eb45bd7adf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectThirdSlot"",
                    ""type"": ""Button"",
                    ""id"": ""10d89562-3adb-4fed-9e97-1cc10bf55c16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectFourthSlot"",
                    ""type"": ""Button"",
                    ""id"": ""f01c34ed-feec-433b-82dd-ffc210e0534c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectFifthSlot"",
                    ""type"": ""Button"",
                    ""id"": ""1f17935f-55b1-49df-92d8-cbbb46c1041e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HideTheWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""7e65aa34-a2e0-42f5-a525-04f2c66cc8f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6502922b-7031-4220-8e03-83e62ab2727f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8322a817-d6bc-4814-9b2f-80437ade5576"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab139df3-5efd-4f46-8bb4-b26366258193"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8f780df-a54f-4859-a9ee-f5fc4181bb9c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""70b9c357-a2bb-4c68-96a0-db85ec264de5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""0262522b-cc3c-4875-ab78-3011c9cd827a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""366e607c-ca81-486a-b37b-edcf844fbdbc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""944c4404-d964-48f3-87fc-cd1301f7eb6c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8bcfdf9-89e4-4331-a98e-14a6e2cd8bb7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""665588bb-c4be-4159-937c-dbda63b643ad"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d2e95295-6164-4ad3-8c45-08d76d07f06e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bf3641c-f53e-4fd8-8aac-5f26ef2da188"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c295a942-f278-40ff-8d03-dd443923ebf0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""892765da-fb91-4431-a8f3-9821e76f7826"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""UseqAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90517ebd-7244-47ce-bed8-9e89ba6f5252"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""UseeAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0742f91-f621-41b7-ab34-19098fdef0b0"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""UserAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecec5587-00f1-46d3-a9d5-8157f584ad5d"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""UsefAbility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcc77d02-8c6a-4f1a-9ece-8ec0f3f2545e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse and Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff2b19d7-0b7c-4dc9-8e3c-a3527c9be7d7"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFirstSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bc5de0d-92a3-41f2-8c12-525994b3898d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSecondSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""215c3ae1-34c0-42c6-a6a4-ff4b9d864541"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectThirdSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""483b73bf-7316-4533-b642-9d1818b9470f"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFourthSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80e700ee-9a0a-436f-9898-69f51da0104f"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFifthSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba100ee5-28c6-49cb-9c3d-ab4e25604a51"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HideTheWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse and Keyboard"",
            ""bindingGroup"": ""Mouse and Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_UseqAbility = m_Player.FindAction("UseqAbility", throwIfNotFound: true);
        m_Player_UseeAbility = m_Player.FindAction("UseeAbility", throwIfNotFound: true);
        m_Player_UserAbility = m_Player.FindAction("UserAbility", throwIfNotFound: true);
        m_Player_UsefAbility = m_Player.FindAction("UsefAbility", throwIfNotFound: true);
        m_Player_SelectFirstSlot = m_Player.FindAction("SelectFirstSlot", throwIfNotFound: true);
        m_Player_SelectSecondSlot = m_Player.FindAction("SelectSecondSlot", throwIfNotFound: true);
        m_Player_SelectThirdSlot = m_Player.FindAction("SelectThirdSlot", throwIfNotFound: true);
        m_Player_SelectFourthSlot = m_Player.FindAction("SelectFourthSlot", throwIfNotFound: true);
        m_Player_SelectFifthSlot = m_Player.FindAction("SelectFifthSlot", throwIfNotFound: true);
        m_Player_HideTheWeapon = m_Player.FindAction("HideTheWeapon", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_UseqAbility;
    private readonly InputAction m_Player_UseeAbility;
    private readonly InputAction m_Player_UserAbility;
    private readonly InputAction m_Player_UsefAbility;
    private readonly InputAction m_Player_SelectFirstSlot;
    private readonly InputAction m_Player_SelectSecondSlot;
    private readonly InputAction m_Player_SelectThirdSlot;
    private readonly InputAction m_Player_SelectFourthSlot;
    private readonly InputAction m_Player_SelectFifthSlot;
    private readonly InputAction m_Player_HideTheWeapon;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @UseqAbility => m_Wrapper.m_Player_UseqAbility;
        public InputAction @UseeAbility => m_Wrapper.m_Player_UseeAbility;
        public InputAction @UserAbility => m_Wrapper.m_Player_UserAbility;
        public InputAction @UsefAbility => m_Wrapper.m_Player_UsefAbility;
        public InputAction @SelectFirstSlot => m_Wrapper.m_Player_SelectFirstSlot;
        public InputAction @SelectSecondSlot => m_Wrapper.m_Player_SelectSecondSlot;
        public InputAction @SelectThirdSlot => m_Wrapper.m_Player_SelectThirdSlot;
        public InputAction @SelectFourthSlot => m_Wrapper.m_Player_SelectFourthSlot;
        public InputAction @SelectFifthSlot => m_Wrapper.m_Player_SelectFifthSlot;
        public InputAction @HideTheWeapon => m_Wrapper.m_Player_HideTheWeapon;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @UseqAbility.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseqAbility;
                @UseqAbility.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseqAbility;
                @UseqAbility.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseqAbility;
                @UseeAbility.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseeAbility;
                @UseeAbility.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseeAbility;
                @UseeAbility.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUseeAbility;
                @UserAbility.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUserAbility;
                @UserAbility.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUserAbility;
                @UserAbility.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUserAbility;
                @UsefAbility.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUsefAbility;
                @UsefAbility.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUsefAbility;
                @UsefAbility.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUsefAbility;
                @SelectFirstSlot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFirstSlot;
                @SelectFirstSlot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFirstSlot;
                @SelectFirstSlot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFirstSlot;
                @SelectSecondSlot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectSecondSlot;
                @SelectSecondSlot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectSecondSlot;
                @SelectSecondSlot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectSecondSlot;
                @SelectThirdSlot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectThirdSlot;
                @SelectThirdSlot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectThirdSlot;
                @SelectThirdSlot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectThirdSlot;
                @SelectFourthSlot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFourthSlot;
                @SelectFourthSlot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFourthSlot;
                @SelectFourthSlot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFourthSlot;
                @SelectFifthSlot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFifthSlot;
                @SelectFifthSlot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFifthSlot;
                @SelectFifthSlot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelectFifthSlot;
                @HideTheWeapon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideTheWeapon;
                @HideTheWeapon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideTheWeapon;
                @HideTheWeapon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideTheWeapon;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @UseqAbility.started += instance.OnUseqAbility;
                @UseqAbility.performed += instance.OnUseqAbility;
                @UseqAbility.canceled += instance.OnUseqAbility;
                @UseeAbility.started += instance.OnUseeAbility;
                @UseeAbility.performed += instance.OnUseeAbility;
                @UseeAbility.canceled += instance.OnUseeAbility;
                @UserAbility.started += instance.OnUserAbility;
                @UserAbility.performed += instance.OnUserAbility;
                @UserAbility.canceled += instance.OnUserAbility;
                @UsefAbility.started += instance.OnUsefAbility;
                @UsefAbility.performed += instance.OnUsefAbility;
                @UsefAbility.canceled += instance.OnUsefAbility;
                @SelectFirstSlot.started += instance.OnSelectFirstSlot;
                @SelectFirstSlot.performed += instance.OnSelectFirstSlot;
                @SelectFirstSlot.canceled += instance.OnSelectFirstSlot;
                @SelectSecondSlot.started += instance.OnSelectSecondSlot;
                @SelectSecondSlot.performed += instance.OnSelectSecondSlot;
                @SelectSecondSlot.canceled += instance.OnSelectSecondSlot;
                @SelectThirdSlot.started += instance.OnSelectThirdSlot;
                @SelectThirdSlot.performed += instance.OnSelectThirdSlot;
                @SelectThirdSlot.canceled += instance.OnSelectThirdSlot;
                @SelectFourthSlot.started += instance.OnSelectFourthSlot;
                @SelectFourthSlot.performed += instance.OnSelectFourthSlot;
                @SelectFourthSlot.canceled += instance.OnSelectFourthSlot;
                @SelectFifthSlot.started += instance.OnSelectFifthSlot;
                @SelectFifthSlot.performed += instance.OnSelectFifthSlot;
                @SelectFifthSlot.canceled += instance.OnSelectFifthSlot;
                @HideTheWeapon.started += instance.OnHideTheWeapon;
                @HideTheWeapon.performed += instance.OnHideTheWeapon;
                @HideTheWeapon.canceled += instance.OnHideTheWeapon;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseandKeyboardSchemeIndex = -1;
    public InputControlScheme MouseandKeyboardScheme
    {
        get
        {
            if (m_MouseandKeyboardSchemeIndex == -1) m_MouseandKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse and Keyboard");
            return asset.controlSchemes[m_MouseandKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUseqAbility(InputAction.CallbackContext context);
        void OnUseeAbility(InputAction.CallbackContext context);
        void OnUserAbility(InputAction.CallbackContext context);
        void OnUsefAbility(InputAction.CallbackContext context);
        void OnSelectFirstSlot(InputAction.CallbackContext context);
        void OnSelectSecondSlot(InputAction.CallbackContext context);
        void OnSelectThirdSlot(InputAction.CallbackContext context);
        void OnSelectFourthSlot(InputAction.CallbackContext context);
        void OnSelectFifthSlot(InputAction.CallbackContext context);
        void OnHideTheWeapon(InputAction.CallbackContext context);
    }
}
