using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_Canya", menuName = "Scriptables/Canya")]
public class SO_Canya : ScriptableObject
{
    public float PlayerSpeed;
    public float PeixSpeed; //Hay que cambiar esto por el PeixScriptable speed

    [Header("Comptador")]
    public float FillAmountSpeed; //velocidad de suma
    public float EmpyAmountSpeed; //velocidad de resta


    [Header("PreMinijoc")]
    public int MusiquitaDeAscensor; //tiempo de espera hasta que pica el pez, el nombre es culpa de carmen
    public int TempsDeReaccio; //Quant de temps tens de reaccio per comen?ar el minijoc
}
