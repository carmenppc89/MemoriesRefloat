using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PS_PRT_Idle : PlayerState
{
    public override void EnterState(PlayerController pc)
    {
        // to-do comprobar dia
        pc.PlayerInputActions.PRT.TerminarDia.performed += pc.TerminarDia;
        pc.PlayerInputActions.PRT.StartMJPescaPuerto.performed += pc.StartMJPescaPuerto;
        pc.PlayerInputActions.PRT.MJPescaPuerto.performed -= pc.MJPescaPuerto;
        pc.ActionMap = eScene.PRT;
    }

    public override void ExitState(PlayerController pc)
    {

    }

    public override void UpdateState(PlayerController pc)
    {

    }

}
