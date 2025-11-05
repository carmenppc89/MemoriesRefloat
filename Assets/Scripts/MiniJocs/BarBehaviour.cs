using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// todo - Recibir Inputs
public class BarBehaviour : MonoBehaviour
{
    private DisplayMJCanya m_Display;
    private void OnEnable()
    {
        m_Display = transform.parent.parent.GetComponent<DisplayMJCanya>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Movement_Peix")
        {
            m_Display.EnterTrigger();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Movement_Peix")
        {
            m_Display.ExitTrigger();
        }
    }

}
