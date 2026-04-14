using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public CanvasGroup fadeCanvasGroup;
    public float fadeDuration = 1.0f;

    public void ChangeSceneAction(string sceneName)
    {
        StartCoroutine(FadeAndChange(sceneName));
    }

    private IEnumerator FadeAndChange(string sceneName)
    {
        float timer = 0;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            if (fadeCanvasGroup != null)
                fadeCanvasGroup.alpha = timer / fadeDuration;

            yield return null;
        }

        SceneManager.LoadScene(sceneName);
    }
}