using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarBehaviour : MonoBehaviour
{
    private void OnEnable()
    {
        DisplayMJCanya m_Display = transform.parent.GetComponent<DisplayMJCanya>();
        //m_Display
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{this.name} -> {collision.gameObject.name}");
        if (collision.gameObject.name == "Movement_Peix")
        {
            Debug.Log($"a");
            //prog();
        }
    }
    
}
