using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [Header("Menu_Puerto")]
    private GameObject m_MJC_Canvas;
    [SerializeField] private float m_anchors = 0.8f;

    public void SceneStarter(Scene scene)
    {
        switch (scene.name)
        {
            case "Menu_Puerto":
                GameObject.Find("MJC_Canvas").GetComponent<DisplayMJCanya>().SetAnchors(m_anchors);

                break;

            default:

                break;
        }
    }
    public void SceneFinicher(Scene scene) { }
}
