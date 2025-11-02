using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMJCanya : MonoBehaviour
{
    [SerializeField]
    private SO_Canya SO_Canya;

    // Todos sus hijos a mano
    [Header("Hijos")]
    [SerializeField]
    private Canvas m_canvas;
    [SerializeField]
    private GameObject m_limite;
    [SerializeField]
    private GameObject m_var;
    [SerializeField]
    private GameObject m_peix;
    [SerializeField]
    private GameObject m_marc;
    [SerializeField]
    private GameObject m_progress;
    [SerializeField]
    private GameObject m_progVar;
    [SerializeField]
    private GameObject m_progMarc;

    private void OnEnable()
    {
        m_canvas.renderMode = RenderMode.ScreenSpaceCamera;
        m_canvas.worldCamera = FindAnyObjectByType(typeof(Camera)) as Camera;
    }
    void Start()
    {

    }

    void Update()
    {

    }

    private void GetChildren()
    {

    }
}
