using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // +    State   +
    public eScene ActionMap;
    private PlayerState m_currentPlayerState;
    private PS_PRT_Idle m_PuertoIdle;
    private PS_PRT_Waiting m_PuertoWaiting;
    private PS_PRT_Fishing m_PuertoFishing;
    private PS_PRT_Sleeping m_PuertoSleeping;
    private PS_PRT_Sailing m_PuertoSailing;
    // -    State   -

    //  +   InputSystem   +
    public PlayerInputSystem PlayerInputActions;
    public PlayerInputSystem Actions => PlayerInputActions;
    //  -   InputSystem   -

    void Start()
    {
        PlayerInputActions = new PlayerInputSystem();
        PlayerInputActions.PRT.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_currentPlayerState != null)
            m_currentPlayerState.UpdateState(this);
    }
    public void SwitchState(PlayerState newState)
    {
        if (CanSwitch(newState))
        {
            m_currentPlayerState.ExitState(this);
            newState.EnterState(this);
            m_currentPlayerState = newState;
        }
    }
    private bool CanSwitch(PlayerState newState)
    {
        // todo - canswitch
        return true;
    }

    public void TerminarDia(InputAction.CallbackContext context)
    {
        SwitchState(m_PuertoSleeping);
    }
    public void StartMJPescaPuerto(InputAction.CallbackContext context)
    {
        SwitchState(m_PuertoFishing);
    }
    public void MJPescaPuerto(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
