using UnityEngine;

public abstract class PlaterState
{
    public abstract void EnterState(PlayerController player);

    public abstract void UpdateState(PlayerController player);

    public abstract void ExitState(PlayerController player);
}

