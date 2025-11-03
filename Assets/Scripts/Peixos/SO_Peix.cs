using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public enum comportament { estatic, movil, espantadis }
[CreateAssetMenu(fileName = "PeixScriptable", menuName = "Scriptables/Peix")]
public class SO_Peix : ScriptableObject
{
    [Header("Aparicio")]
    //public List<Estacions> estacions;
    //public List<Atmosferes> atmosferas;
    //public List<Hores> temps;

    [Header("Xarxa i Canya")]
    public float dificultatCanya;
    public bool xarxaPeixExtra;

    [Header("Busseig")]
    public bool isMolusc;
    public comportament busseigComportament;
}
