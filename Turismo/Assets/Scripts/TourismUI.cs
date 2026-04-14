using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TourismUI : MonoBehaviour
{
    public Image highlightImage;
    public TMP_Text titleText;
    public TMP_Text descriptionText;

    public Image mapDisplay;
    public TMP_Text tipsText;

    public void ChangeItem(
        Sprite newImage,
        string newTitle,
        string newDescription,
        Sprite newMap,
        string newTips
    )
    {
        highlightImage.sprite = newImage;
        titleText.text = newTitle;
        descriptionText.text = newDescription;

        mapDisplay.sprite = newMap;
        tipsText.text = newTips;
    }
}