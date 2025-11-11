using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum eHora { Noche, Tarde, Mañana }
public enum eDiaSetmana { Mon, Tue, Wen, Thu, Fri, Sat, San }

public class DisplayUI_Dia : MonoBehaviour
{
    [SerializeField] private TextMeshPro m_TXTDia;
    [SerializeField] private Image m_IMGDia1;
    [SerializeField] private Image m_IMGDia2;

    public void SetDia(int dia)
    {
        m_TXTDia.text = Enum.GetValues(typeof(eDiaSetmana)).GetValue(dia).ToString();
        SetTime(eHora.Mañana);
    }

    public void SetTime(eHora hora)
    {
        m_IMGDia2.gameObject.SetActive(hora == eHora.Mañana ? true : false);
        m_IMGDia1.gameObject.SetActive(hora > 0 ? true : false);
    }

}
