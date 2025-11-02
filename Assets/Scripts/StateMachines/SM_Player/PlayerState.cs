using UnityEngine;

public abstract class PlayerState
{
    public abstract void EnterState();

    public abstract void UpdateState();

    public abstract void ExitState();
}