using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMJCanya : MonoBehaviour
{
    [Header("Paranetros de la Canya")]
    [SerializeField] private SO_Canya SO_Canya;

    // Todos sus hijos a mano
    [Header("Hijos")]
    [SerializeField] private RectTransform m_MJC;
    [SerializeField] private Image m_IMGProgress;
    [SerializeField] private RectTransform m_Llinya;
    [SerializeField] private RectTransform m_Peix;

    private Coroutine m_PujarComptador;
    private Coroutine m_BaixarComptador;
    private bool m_end = false;

    private Canvas m_Canvas = null;

    private void OnEnable()
    {
        m_Canvas = m_Canvas ?? GetComponent<Canvas>();
        if (m_Canvas.worldCamera == null)
        {
            m_Canvas.renderMode = RenderMode.ScreenSpaceCamera;
            m_Canvas.worldCamera = Camera.main;
        }

        // todo Resetear posiciones
        m_IMGProgress.fillAmount = 0;
        m_Peix.anchoredPosition = Vector3.zero;
        m_Llinya.anchoredPosition = Vector3.zero;
    }
    private void OnDisable()
    {
        m_Canvas = null;
        StopAllCoroutines();
    }

    public void EnterTrigger()
    {
        m_PujarComptador = StartCoroutine(PujarComptador());
        if (m_BaixarComptador != null)
            StopCoroutine(m_BaixarComptador);
    }
    public void ExitTrigger()
    {
        if (!m_end)
        {
            StopCoroutine(m_PujarComptador);
            if (gameObject.activeSelf)
                m_BaixarComptador = StartCoroutine(BaixarComptador());
        }
    }
    IEnumerator PujarComptador()
    {
        while (!m_end)
        {
            m_IMGProgress.fillAmount += SO_Canya.FillAmountSpeed;

            if (m_IMGProgress.fillAmount >= 1)
            {
                Debug.Log("Has pescado el pez!!");
                SortirMinijoc(null);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator BaixarComptador()
    {
        while (!m_end)
        {
            m_IMGProgress.fillAmount -= SO_Canya.EmpyAmountSpeed;
            if (m_IMGProgress.fillAmount <= 0)
            {
                Debug.Log("Has perdido el pez :(");
                SortirMinijoc(null);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
    private void SortirMinijoc(SO_Peix peix)
    {
        m_end = true;
        StopAllCoroutines();

        this.gameObject.SetActive(false);

        //m_PlayerInputActions.MinijocCanya.Moviment.started -= Moviment;
        //m_PlayerInputActions.MinijocCanya.Moviment.canceled -= Stop;
        //m_PlayerInputActions.MinijocCanya.Disable();
        //m_mySpot.GetionPecesCanya(peix);
        //m_MJCEnd.Raise();
    }

    public void SetAnchors(float anchor)
    {
        // 0.5 Ó 0.7
        m_MJC.anchorMin = new Vector2(anchor, 0.5f);
        m_MJC.anchorMax = new Vector2(anchor, 0.5f);

        m_MJC.anchoredPosition = Vector2.zero;
    }
}
