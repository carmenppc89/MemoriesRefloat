using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

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
    private Image imgProgress;
    [SerializeField] private GameObject m_progMarc;

    private bool m_end = false;

    private void OnEnable()
    {
        // ajustar el canvas a la camara
        m_canvas.renderMode = RenderMode.ScreenSpaceCamera;
        m_canvas.worldCamera = FindAnyObjectByType(typeof(Camera)) as Camera;

        imgProgress = m_progVar.GetComponent<Image>();
        imgProgress.fillAmount = 0;
    }
    private void OnDisable()
    {
        // todo Resetear posiciones
    }

    // to-do corrutina de entrar y de salir
    IEnumerator PujarComptador()
    {
        while (!m_end)
        {
            imgProgress.fillAmount += SO_Canya.FillAmountSpeed;

            if (imgProgress.fillAmount >= 1)
            {
                Debug.Log("Has pescado el pez!!");
                //SortirMinijoc(m_mySpot.peixSpot);
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator BaixarComptador()
    {
        while (!m_end)
        {
            imgProgress.fillAmount -= SO_Canya.EmpyAmountSpeed;
            if (imgProgress.fillAmount <= 0)
            {
                Debug.Log("Has perdido el pez :(");
                SortirMinijoc(null);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
    private void SortirMinijoc(PeixScriptable peix)
    {
        m_end = true;
        StopAllCoroutines();

        //m_PlayerInputActions.MinijocCanya.Moviment.started -= Moviment;
        //m_PlayerInputActions.MinijocCanya.Moviment.canceled -= Stop;
        //m_PlayerInputActions.MinijocCanya.Disable();
        //m_mySpot.GetionPecesCanya(peix);
        //m_MJCEnd.Raise();
    }
}
