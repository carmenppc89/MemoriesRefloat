using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public enum comportament { estatic, movil, espantadis }
[CreateAssetMenu(fileName = "SO_Peix", menuName = "Scriptables/Peix")]
public class SO_Peix : SO_Item
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
