using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_Item", menuName = "Scriptables/Item")]
public class SO_Item : ScriptableObject
{
    [Header("Basics")]
    public int idObj;
    public string nom;
    public int preuAct;
    public int preu;
    public Sprite sprite;

    [Header("Crafting")]
    public bool isMaterial;

    public void Rebaixa(float percent)
    {
        preuAct = (int)(preuAct * (1 - percent));

        if (preuAct < 5)
            preuAct = 5;

    }

    public void PujarPreu(float percent)
    {
        preuAct += (int)(preuAct * (percent));

        if (preuAct > (preu * preu))
            preuAct = (preu * preu);
    }

}


