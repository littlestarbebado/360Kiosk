using UnityEngine;
using UnityEngine.Video;

public class CultureItem : MonoBehaviour
{
    public CultureUI manager;

    public bool isVideo;

    public Sprite image;
    public VideoClip video;

    public string title;
    [TextArea] public string description;

    public void OnClick()
    {
        if (isVideo)
        {
            manager.ShowVideo(video, title, description);
        }
        else
        {
            manager.ShowImage(image, title, description);
        }
    }
}
