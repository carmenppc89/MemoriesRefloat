using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // +    State   +
    private PlayerState m_currentPlayerState;
    private PS_PRT_Idle m_PuertoIdle;
    private PS_PRT_Waiting m_PuertoWaiting;
    private PS_PRT_Fishing m_PuertoFishing;
    private PS_PRT_Sleeping m_PuertoSleeping;
    private PS_PRT_Sailing m_PuertoSailing;
    // -    State   -

    //  +   InputSystem   +
    PlayerInputSystem m_PlayerInputActions;
    public PlayerInputSystem Actions => m_PlayerInputActions;
    //  -   InputSystem   -

    void Start()
    {
        m_PlayerInputActions = new PlayerInputSystem();
        //m_PlayerInputActions.Port.Enable();
        //m_PlayerInputActions.Port.Moviment.performed += Moviment;
        //m_PlayerInputActions.Port.Moviment.canceled += Stop;
        //m_PlayerInputActions.Port.Pesca.performed += Pescar;
        //m_PlayerInputActions.Port.Inventari.performed += Inventari;
        //m_PlayerInputActions.Port.Interactuar.performed += Interactuar;
        //m_PlayerInputActions.Port.Exit.canceled -= Exit;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (m_currentPlayerState != null)
            m_currentPlayerState.UpdateState(this);
    }
}
