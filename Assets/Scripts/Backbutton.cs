using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject culturePanel;
    public GameObject countryMenu;

    public void GoBack()
    {
        culturePanel.SetActive(false);
        countryMenu.SetActive(true);
    }
}