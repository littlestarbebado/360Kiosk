using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void GoToMap()
    {
        SceneManager.LoadScene("Mapa");
    }
}