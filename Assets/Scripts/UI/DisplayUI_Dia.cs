using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI_Dia : MonoBehaviour
{
    [SerializeField] private Image m_IMGProgress;

    private void SetIMGProgress(float amount)
    {
        m_IMGProgress.fillAmount = amount;
    }

    private void AddIMGProgress(float amount)
    {
        m_IMGProgress.fillAmount += amount;

        if (m_IMGProgress.fillAmount == 0)
            Debug.LogWarning("NOT IMPLEMENTED - end day"); // todo - EndDay
    }

}
