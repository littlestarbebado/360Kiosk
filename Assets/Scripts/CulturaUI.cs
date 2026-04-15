using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class CultureUI : MonoBehaviour
{
    public Image mainImage;
    public GameObject videoObject;
    public VideoPlayer videoPlayer;

    public TMP_Text titleText;
    public TMP_Text descriptionText;

    public void ShowImage(Sprite img, string title, string desc)
    {
        mainImage.gameObject.SetActive(true);
        videoObject.SetActive(false);

        mainImage.sprite = img;
        titleText.text = title;
        descriptionText.text = desc;
    }

    public void ShowVideo(VideoClip clip, string title, string desc)
    {
        mainImage.gameObject.SetActive(false);
        videoObject.SetActive(true);

        videoPlayer.clip = clip;
        videoPlayer.Play();

        titleText.text = title;
        descriptionText.text = desc;
    }
}