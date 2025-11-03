using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeixBehaviour : MonoBehaviour
{
    [SerializeField] private RectTransform m_limiteL;
    private float m_limiteL_X;
    [SerializeField] private RectTransform m_limiteR;
    private float m_limiteR_X;

    [SerializeField] private Vector3 m_offset;
    [SerializeField] private Vector3 m_velocity = Vector3.zero;
    [SerializeField] private float m_smoothTime = 0.3f;
    [SerializeField] private Vector3 m_nextPos;

    private RectTransform m_RectTrans;

    private void OnEnable()
    {
        m_RectTrans = GetComponent<RectTransform>();
        transform.position = new Vector3(0, 0, 0);

        float a = m_limiteL.anchoredPosition.x;
        float b = m_limiteR.anchoredPosition.x;
        float c = m_RectTrans.rect.width / 2;

        m_limiteL_X = m_limiteL.anchoredPosition.x - (m_RectTrans.rect.width / 2);
        m_limiteR_X = m_limiteR.anchoredPosition.x + (m_RectTrans.rect.width / 2);

        m_nextPos = SetNextPos();
    }

    void Update()
    {
        // direccion velocidad
        this.transform.position =
            Vector3.SmoothDamp(transform.position,
            m_nextPos + m_offset,
            ref m_velocity, m_smoothTime);

        if (transform.position == m_nextPos)
            m_nextPos = SetNextPos();
    }

    private Vector3 SetNextPos()
    {
        return new Vector3(Random.Range(m_limiteL_X, m_limiteR_X), 0, 0);
    }

}
