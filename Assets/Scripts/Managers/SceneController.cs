using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;

public class SceneController : MonoBehaviour
{
    private List<Canvas> m_ListCanvas = new List<Canvas>();
    private Camera m_Cam;

    [Header("Menu_Puerto")]
    private GameObject m_MJC_Canvas;
    [SerializeField] private float m_anchors = 0.8f;

    private void Awake()
    {
        Debug.Log($"AWK -> {this.name}");
    }

    public void SceneStarter(Scene scene)
    {

        switch (scene.name)
        {
            case "Menu_Puerto":

                m_Cam = Camera.main;

                m_MJC_Canvas = GameObject.Find("CNV_MJC");
                if (!m_MJC_Canvas.IsUnityNull())
                {
                    m_MJC_Canvas.GetComponent<DisplayMJCanya>().SetAnchors(m_anchors);
                    m_MJC_Canvas.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -20.0f);
                    m_MJC_Canvas.SetActive(false);
                }

                break;

            default:

                break;
        }
        CamaraOnCanvas();
    }
    public void SceneFinisher(Scene scene) { }

    private void CamaraOnCanvas()
    {
        m_ListCanvas = new List<Canvas>();

        m_ListCanvas = ((GameObject.FindObjectsByType<Canvas>(FindObjectsSortMode.None)).ToList());
        foreach (Canvas c in m_ListCanvas)
        {
            c.renderMode = RenderMode.ScreenSpaceCamera;
            c.worldCamera = m_Cam;
        }
    }
}
