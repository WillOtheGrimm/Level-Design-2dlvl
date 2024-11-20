// GENERATED AUTOMATICALLY FROM 'Assets/LDP/content/Params/InputSystem.actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace DevDev.LDP.Input
{
    public class @InputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem.actions"",
    ""maps"": [
        {
            ""name"": ""PawnControl"",
            ""id"": ""7c9c7b96-c100-4056-8d28-e1ff1b75b0f9"",
            ""actions"": [
                {
                    ""name"": ""aimDir"",
                    ""type"": ""Value"",
                    ""id"": ""438dc4d7-11aa-411e-921f-1cf4eb58f4ec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone(min=0.2,max=0.9)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""point"",
                    ""type"": ""Value"",
                    ""id"": ""4b60db53-b255-43ed-bb0b-d38eafab595c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pointDelta"",
                    ""type"": ""Value"",
                    ""id"": ""6260ade9-2493-4208-b1a7-eb6a547f6087"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""9a265669-760e-43ef-b444-a2e671914404"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone(min=0.2,max=0.9)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""b7ae9841-86a7-421a-bb03-f2b3ea7353ed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fbc0647a-314d-4c5d-85dc-200310179af5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""aimDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""9b0867cb-90a7-4f14-96a7-9af049871367"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""aimDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e7c25426-e507-4ada-9137-78370fbb4783"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""aimDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b61dd080-e4e5-436f-b50c-58aa2323192c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""aimDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""143bc74c-8817-4510-8e66-41b5e8038b8b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""aimDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e692742d-607f-4324-ba07-0ea320932dc3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""aimDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""44cefeba-f6d1-4728-8f2b-f95150750088"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""4a025282-1ef7-42fa-9db9-300455d6df61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0697da4e-d134-4e24-bdb7-059cf606b7fd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2aef461e-2780-4052-8d5c-af49d69d4d2a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cb4addbf-e8ce-4ec1-bb15-858b2d8a10be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""810728b8-0d77-4df6-a12b-13261e865db6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""dpad"",
                    ""id"": ""7b183bec-ef8b-42ae-b1d1-6c769d422b4a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""725e8ce4-49cf-4b6c-8e36-b3bc2351d118"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b98c516f-939e-4409-9f65-62587c0c8fcd"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""576b5f1a-f10c-41cb-8aa9-fb49adbdc29d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c683c255-eb2b-4109-9889-e24536262cd8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrows"",
                    ""id"": ""ce4f184e-ef68-440a-88bf-9d533cfc0590"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e101557c-2ffa-4f6c-9b28-0e9d2bc0136b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc125b11-64d4-4779-92d3-77345b201a50"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ae936747-e360-4c65-a114-c7c1befb0230"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b261fb51-699e-4d71-b4cd-33fad00f5f56"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5bb28426-66a3-4c7e-b42c-7dfd4e7de4dd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8764b41-cd08-4fd8-922d-b284c81cc22f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10fab4ac-1dcc-4d90-8cec-2020ebbc40fa"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4d065f2-88be-473a-9974-9641fff196ba"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""pointDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""faf28b78-6e58-4f1a-b5bf-05b8aa113fcc"",
            ""actions"": [
                {
                    ""name"": ""submit"",
                    ""type"": ""Button"",
                    ""id"": ""d1a17523-163e-437c-b89f-c61c4bc9011d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e20b50a5-d868-4d35-aa43-c489abec2e12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fcf0c21e-fcd2-4f21-a797-5c457ab36f99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pointerDelta"",
                    ""type"": ""Value"",
                    ""id"": ""09bf63bd-b038-437f-a22f-4deaf4967a90"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""537733a6-42af-4bf8-98e6-26bae2cda6e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d06dbef-eb81-4ba3-a780-ecfec2f31322"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""8db762b4-f45c-4ec5-b312-d16230c3afcb"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ec4129b5-2dcb-4ff9-9a5b-fd0c5b35496b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d7a6de52-4968-4239-a2a6-7cfa3554c1bb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""724cffe7-db3b-4194-9b14-46420bfd32ac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dd9d4a9d-e8f0-408a-b85e-06896607be13"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""arrowKeys"",
                    ""id"": ""8258ada1-9e9e-4a8d-a604-0230893a3e9c"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cdd24890-309e-426a-91b1-ead77a338096"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""68b42ee2-352c-4b13-a968-bc0eef883e0e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""899c763c-0f2b-4f4f-8f89-d8d72ff9effd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""68d33c9b-0310-4f1c-8145-e4059755491f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d0913208-5669-4a98-baa7-67dc0ec7f674"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abc5ed73-18ce-4526-812d-f2a0dec973a2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b92c766f-833b-43da-969c-405b1200ad48"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""pointerDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7da0bc95-9c52-47c1-ac8a-7502d2cd88a2"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dc6077f-0fc9-4e7c-87dd-014e3c395780"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd303ace-7944-4fe9-82ab-230d8360036a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""781fb910-4378-41db-908f-8cf030d9a098"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b88ba32e-431f-4d45-be2a-77109f4df77e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""General"",
            ""id"": ""cd9626fb-8a54-4783-af2e-e9aefcb7d90a"",
            ""actions"": [
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""c1a1a2b0-6057-41d7-917e-c33391e1f33c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""fullScreen"",
                    ""type"": ""Button"",
                    ""id"": ""46339bcd-c35b-408e-bc40-a438a5332892"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""debugScreen"",
                    ""type"": ""Button"",
                    ""id"": ""5bfa5d1a-b013-488f-b3fd-13b752a5c1bc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67d9225b-b517-411c-9754-6f7f0d7c2f60"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97c0ce67-27ac-468c-81ad-dd24445708d3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""d0eb1230-44b7-4c6e-bd8a-fd2854b57dae"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fullScreen"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""3200fd08-e034-45aa-92df-9363fe979396"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""fullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""010a1c5c-8160-4aed-93a9-993d9d1ab02d"",
                    ""path"": ""<Keyboard>/#(F)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""fullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""0ad896b6-69e0-4035-8c3c-287e3ffadcb9"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""fullScreen"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""667760f3-0c31-487a-ad2c-d39616f8d5c5"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""fullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""9b8a1778-f909-4437-9c33-e5bb071a71fe"",
                    ""path"": ""<Keyboard>/f11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""fullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""34b4ec16-40bd-4cac-b8b8-e0549b1d6ada"",
                    ""path"": ""<Keyboard>/f11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""fullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfc58e28-60e9-4aa6-b41f-361f05fe571f"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""debugScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3531cb70-5512-4d34-88d2-3e6729906f76"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse And Keyboard"",
                    ""action"": ""debugScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse And Keyboard"",
            ""bindingGroup"": ""Mouse And Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // PawnControl
            m_PawnControl = asset.FindActionMap("PawnControl", throwIfNotFound: true);
            m_PawnControl_aimDir = m_PawnControl.FindAction("aimDir", throwIfNotFound: true);
            m_PawnControl_point = m_PawnControl.FindAction("point", throwIfNotFound: true);
            m_PawnControl_pointDelta = m_PawnControl.FindAction("pointDelta", throwIfNotFound: true);
            m_PawnControl_move = m_PawnControl.FindAction("move", throwIfNotFound: true);
            m_PawnControl_jump = m_PawnControl.FindAction("jump", throwIfNotFound: true);
            // UI
            m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
            m_UI_submit = m_UI.FindAction("submit", throwIfNotFound: true);
            m_UI_click = m_UI.FindAction("click", throwIfNotFound: true);
            m_UI_point = m_UI.FindAction("point", throwIfNotFound: true);
            m_UI_pointerDelta = m_UI.FindAction("pointerDelta", throwIfNotFound: true);
            m_UI_move = m_UI.FindAction("move", throwIfNotFound: true);
            // General
            m_General = asset.FindActionMap("General", throwIfNotFound: true);
            m_General_pause = m_General.FindAction("pause", throwIfNotFound: true);
            m_General_fullScreen = m_General.FindAction("fullScreen", throwIfNotFound: true);
            m_General_debugScreen = m_General.FindAction("debugScreen", throwIfNotFound: true);
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

        // PawnControl
        private readonly InputActionMap m_PawnControl;
        private IPawnControlActions m_PawnControlActionsCallbackInterface;
        private readonly InputAction m_PawnControl_aimDir;
        private readonly InputAction m_PawnControl_point;
        private readonly InputAction m_PawnControl_pointDelta;
        private readonly InputAction m_PawnControl_move;
        private readonly InputAction m_PawnControl_jump;
        public struct PawnControlActions
        {
            private @InputActions m_Wrapper;
            public PawnControlActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @aimDir => m_Wrapper.m_PawnControl_aimDir;
            public InputAction @point => m_Wrapper.m_PawnControl_point;
            public InputAction @pointDelta => m_Wrapper.m_PawnControl_pointDelta;
            public InputAction @move => m_Wrapper.m_PawnControl_move;
            public InputAction @jump => m_Wrapper.m_PawnControl_jump;
            public InputActionMap Get() { return m_Wrapper.m_PawnControl; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PawnControlActions set) { return set.Get(); }
            public void SetCallbacks(IPawnControlActions instance)
            {
                if (m_Wrapper.m_PawnControlActionsCallbackInterface != null)
                {
                    @aimDir.started -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnAimDir;
                    @aimDir.performed -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnAimDir;
                    @aimDir.canceled -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnAimDir;
                    @point.started -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPoint;
                    @point.performed -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPoint;
                    @point.canceled -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPoint;
                    @pointDelta.started -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPointDelta;
                    @pointDelta.performed -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPointDelta;
                    @pointDelta.canceled -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnPointDelta;
                    @move.started -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnMove;
                    @move.performed -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnMove;
                    @move.canceled -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnMove;
                    @jump.started -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnJump;
                    @jump.performed -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnJump;
                    @jump.canceled -= m_Wrapper.m_PawnControlActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_PawnControlActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @aimDir.started += instance.OnAimDir;
                    @aimDir.performed += instance.OnAimDir;
                    @aimDir.canceled += instance.OnAimDir;
                    @point.started += instance.OnPoint;
                    @point.performed += instance.OnPoint;
                    @point.canceled += instance.OnPoint;
                    @pointDelta.started += instance.OnPointDelta;
                    @pointDelta.performed += instance.OnPointDelta;
                    @pointDelta.canceled += instance.OnPointDelta;
                    @move.started += instance.OnMove;
                    @move.performed += instance.OnMove;
                    @move.canceled += instance.OnMove;
                    @jump.started += instance.OnJump;
                    @jump.performed += instance.OnJump;
                    @jump.canceled += instance.OnJump;
                }
            }
        }
        public PawnControlActions @PawnControl => new PawnControlActions(this);

        // UI
        private readonly InputActionMap m_UI;
        private IUIActions m_UIActionsCallbackInterface;
        private readonly InputAction m_UI_submit;
        private readonly InputAction m_UI_click;
        private readonly InputAction m_UI_point;
        private readonly InputAction m_UI_pointerDelta;
        private readonly InputAction m_UI_move;
        public struct UIActions
        {
            private @InputActions m_Wrapper;
            public UIActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @submit => m_Wrapper.m_UI_submit;
            public InputAction @click => m_Wrapper.m_UI_click;
            public InputAction @point => m_Wrapper.m_UI_point;
            public InputAction @pointerDelta => m_Wrapper.m_UI_pointerDelta;
            public InputAction @move => m_Wrapper.m_UI_move;
            public InputActionMap Get() { return m_Wrapper.m_UI; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
            public void SetCallbacks(IUIActions instance)
            {
                if (m_Wrapper.m_UIActionsCallbackInterface != null)
                {
                    @submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                    @click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                    @point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                    @pointerDelta.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerDelta;
                    @pointerDelta.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerDelta;
                    @pointerDelta.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerDelta;
                    @move.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                    @move.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                    @move.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_UIActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @submit.started += instance.OnSubmit;
                    @submit.performed += instance.OnSubmit;
                    @submit.canceled += instance.OnSubmit;
                    @click.started += instance.OnClick;
                    @click.performed += instance.OnClick;
                    @click.canceled += instance.OnClick;
                    @point.started += instance.OnPoint;
                    @point.performed += instance.OnPoint;
                    @point.canceled += instance.OnPoint;
                    @pointerDelta.started += instance.OnPointerDelta;
                    @pointerDelta.performed += instance.OnPointerDelta;
                    @pointerDelta.canceled += instance.OnPointerDelta;
                    @move.started += instance.OnMove;
                    @move.performed += instance.OnMove;
                    @move.canceled += instance.OnMove;
                }
            }
        }
        public UIActions @UI => new UIActions(this);

        // General
        private readonly InputActionMap m_General;
        private IGeneralActions m_GeneralActionsCallbackInterface;
        private readonly InputAction m_General_pause;
        private readonly InputAction m_General_fullScreen;
        private readonly InputAction m_General_debugScreen;
        public struct GeneralActions
        {
            private @InputActions m_Wrapper;
            public GeneralActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @pause => m_Wrapper.m_General_pause;
            public InputAction @fullScreen => m_Wrapper.m_General_fullScreen;
            public InputAction @debugScreen => m_Wrapper.m_General_debugScreen;
            public InputActionMap Get() { return m_Wrapper.m_General; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
            public void SetCallbacks(IGeneralActions instance)
            {
                if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
                {
                    @pause.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                    @pause.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                    @pause.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                    @fullScreen.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFullScreen;
                    @fullScreen.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFullScreen;
                    @fullScreen.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFullScreen;
                    @debugScreen.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDebugScreen;
                    @debugScreen.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDebugScreen;
                    @debugScreen.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDebugScreen;
                }
                m_Wrapper.m_GeneralActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @pause.started += instance.OnPause;
                    @pause.performed += instance.OnPause;
                    @pause.canceled += instance.OnPause;
                    @fullScreen.started += instance.OnFullScreen;
                    @fullScreen.performed += instance.OnFullScreen;
                    @fullScreen.canceled += instance.OnFullScreen;
                    @debugScreen.started += instance.OnDebugScreen;
                    @debugScreen.performed += instance.OnDebugScreen;
                    @debugScreen.canceled += instance.OnDebugScreen;
                }
            }
        }
        public GeneralActions @General => new GeneralActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_MouseAndKeyboardSchemeIndex = -1;
        public InputControlScheme MouseAndKeyboardScheme
        {
            get
            {
                if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse And Keyboard");
                return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
            }
        }
        public interface IPawnControlActions
        {
            void OnAimDir(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnPointDelta(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
        public interface IUIActions
        {
            void OnSubmit(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnPointerDelta(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
        }
        public interface IGeneralActions
        {
            void OnPause(InputAction.CallbackContext context);
            void OnFullScreen(InputAction.CallbackContext context);
            void OnDebugScreen(InputAction.CallbackContext context);
        }
    }
}
