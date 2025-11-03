using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{this.name} -> {collision.gameObject.name}");
        if (collision.gameObject.name == "Movement_Peix")
        {
            Debug.Log($"a");
        }
    }
}
