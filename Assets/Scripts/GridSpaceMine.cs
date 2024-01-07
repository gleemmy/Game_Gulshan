using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GridSpaceMine : MonoBehaviour

{
    public Button button;
    public TMP_Text buttonText;
    private GameControllerMine gameControllerMine;

    public void SetGameControllerMineReference(GameControllerMine controllermine)
    {
        gameControllerMine = controllermine;
    }
    public void SetSpace()
    {

        buttonText.text = gameControllerMine.GetPlayerSide();
        button.interactable = false;
        gameControllerMine.EndTurn();
    }
}
