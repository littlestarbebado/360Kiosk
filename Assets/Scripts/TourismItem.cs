using UnityEngine;

public class TourismItem : MonoBehaviour
{
    public TourismUI manager;

    public Sprite image;
    public string title;

    [TextArea] public string description;

    public Sprite mapImage;

    [TextArea] public string tips;

    public void OnClick()
    {
        manager.ChangeItem(
            image,
            title,
            description,
            mapImage,
            tips
        );
    }
}