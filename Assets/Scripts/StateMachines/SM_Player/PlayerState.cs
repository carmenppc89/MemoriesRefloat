using UnityEngine;

public enum eScene { PRT, BRC, BUCO };
public abstract class PlayerState
{
    public abstract void EnterState(PlayerController pc);

    public abstract void UpdateState(PlayerController pc);

    public abstract void ExitState(PlayerController pc);
}