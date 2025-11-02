using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeixBehaviour : MonoBehaviour
{
    private float nextPos;
    private float m_limiteL;
    private float m_limiteR;
    private float LimiteL
    {
        get { return m_limiteL; }
        set { m_limiteL = value; }
    }
    private float LimiteR
    {
        get { return m_limiteR; }
        set { m_limiteR = value; }
    }

    private void OnEnable()
    {
        this.transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // direccion velocidad
    }

    private float SetNextPos()
    {
        return Random.Range(LimiteL, LimiteR);
    }
}
