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
    [SerializeField] private GameObject m_peix;
    [SerializeField] private GameObject m_marc;
    [SerializeField] private GameObject m_progress;
    [SerializeField] private GameObject m_progVar;
    [SerializeField] private GameObject m_progMarc;

    private Vector3 m_limitL;
    private Vector3 m_limitR;

    private void OnEnable()
    {
        // ajustar el canvas a la camara
        m_canvas.renderMode = RenderMode.ScreenSpaceCamera;
        m_canvas.worldCamera = FindAnyObjectByType(typeof(Camera)) as Camera;

        // Recoger los limites
        //m_limitL = new Transform(((m_limite.rect.width / 2) - (m_bar.rect.width / 2)), 0, 0);
        m_limitL = new Vector3(-1*(((m_limite.rect.width / 2) - (m_bar.rect.width / 2))), 0, 0);
        m_limitR = new Vector3(((m_limite.rect.width / 2) - (m_bar.rect.width / 2)), 0, 0);


        //m_limite.sizeDelta.x;
        //m_limite.rect.width;
    }

    void Update()
    {

    }

}
