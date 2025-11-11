using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayUI_INVPrice : MonoBehaviour
{
    private TextMeshPro m_TXTprice;
    private int m_intPrice;

    private void Awake()
    {
        m_TXTprice = GetComponent<TextMeshPro>();
        m_TXTprice.text = 0 + "";
    }

    public void SetPrice(int price)
    {
        m_TXTprice.text = price.ToString();
    }

    public void UpdateINVPrice(List<int> obj)
    {
        // todo - ScriptableObj con inventario
        m_intPrice = 0;
        foreach (int p in obj)
        {
            m_intPrice += p;
        }
        SetPrice(m_intPrice);
    }
}
