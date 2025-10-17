using System.Xml.Serialization;
using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class Player : Character, InputSystem_Actions.IPlayerActions
{
    //
    private InputSystem_Actions inputActions;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.SetCallbacks(this);
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _mb.MoveCharacter(context.ReadValue<Vector2>()); //
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }
    //

    void Update()
    {
        //_mb.MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))); //
    }
}
