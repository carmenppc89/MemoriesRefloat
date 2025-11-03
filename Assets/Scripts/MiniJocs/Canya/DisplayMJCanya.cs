using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMJCanya : MonoBehaviour
{
    [SerializeField]
    private SO_Canya SO_Canya;

    // Todos sus hijos a mano
    [Header("Hijos")]
    [SerializeField] private Canvas m_canvas;
    [SerializeField] private RectTransform m_limite;
    [SerializeField] private RectTransform m_bar;
    [SerializeField] private RectTransform m_peix;

    [SerializeField] private GameObject m_marc;
    [SerializeField] private GameObject m_progress;
    [SerializeField] private GameObject m_progVar;
    [SerializeField] private GameObject m_progMarc;

    private float m_limitL;
    private float m_limitR;

    private void OnEnable()
    {
        // ajustar el canvas a la camara
        m_canvas.renderMode = RenderMode.ScreenSpaceCamera;
        m_canvas.worldCamera = FindAnyObjectByType(typeof(Camera)) as Camera;
    }
    private void OnDisable()
    {
        // todo Resetear posiciones
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{this.name} -> {collision.gameObject.name}");
    }

}
