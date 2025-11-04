using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeixBehaviour : MonoBehaviour
{
    [Header("Limites de la Barra")]
    [SerializeField] private RectTransform m_limiteDown;
    private int m_limiteDown_Y;
    [SerializeField] private RectTransform m_limiteUp;
    private int m_limiteUp_Y;

    [Header("Comportamiento del Pez")]
    [SerializeField] private float m_offset = 0.005f;
    [SerializeField] private Vector3 m_velocity = Vector3.zero;
    [SerializeField] private float m_smoothTime = 0.3f;
    [SerializeField] private Vector2 m_nextPos;

    private RectTransform m_RectTrans;

    private void OnDisable()
    {
        m_RectTrans.anchoredPosition3D = new Vector3(0, 0, 0);
        m_nextPos = new Vector2(0, 0);
    }
    private void OnEnable()
    {
        m_RectTrans = GetComponent<RectTransform>();

        m_limiteDown_Y = (int)(m_limiteDown.anchoredPosition.y + ((m_RectTrans.rect.height / 2) + m_limiteDown.rect.height / 2));
        m_limiteUp_Y = (int)(m_limiteUp.anchoredPosition.y - ((m_RectTrans.rect.height / 2) + m_limiteDown.rect.height / 2));

        m_nextPos = SetNextPos();
    }

    void Update()
    {
        m_RectTrans.anchoredPosition =
            Vector3.SmoothDamp(m_RectTrans.anchoredPosition,
            m_nextPos, ref m_velocity, m_smoothTime);

        if (Vector2.Distance(m_RectTrans.anchoredPosition, m_nextPos) <= m_offset)
            m_nextPos = SetNextPos();

    }

    private Vector3 SetNextPos()
    {
        return new Vector3(0, UnityEngine.Random.Range(m_limiteDown_Y, m_limiteUp_Y), 0);
    }

}
