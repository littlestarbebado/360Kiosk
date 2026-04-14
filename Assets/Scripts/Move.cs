using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Move : MonoBehaviour
{
    [SerializeField]
    private Button leftBtn;
    [SerializeField]
    private Button rightBtn;

    private int Spacing = 160; //120 da largura + 40 spacing

    private void MoveBar(int value)
    {
        var currentPosition = this.GetComponent<RectTransform>().localPosition;
        var newPosition = currentPosition;
        newPosition.x += value;
        this.transform.localPosition = newPosition;
        if (newPosition.x >= 0)
        {
            leftBtn.interactable = false;
        }
        else
        {
            leftBtn.interactable = true;
        }
        //TODO: Terminar o Código para fazer disable ao botão da direita.
    }

    public void MoveLeft()
    {
        MoveBar(Spacing);
    }

    public void MoveRight()
    {
        MoveBar(-Spacing);
    }
}