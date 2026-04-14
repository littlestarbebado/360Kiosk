
using UnityEngine;

public class TourismNavigation : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject tipsPanel;
    public GameObject mapPanel;

    public void OpenTips()
    {
        mainPanel.SetActive(false);
        tipsPanel.SetActive(true);
        mapPanel.SetActive(false);
    }

    public void OpenMap()
    {
        mainPanel.SetActive(false);
        tipsPanel.SetActive(false);
        mapPanel.SetActive(true);
    }

    public void Back()
    {
        mainPanel.SetActive(true);
        tipsPanel.SetActive(false);
        mapPanel.SetActive(false);
    }
}