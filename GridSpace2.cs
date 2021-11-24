using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace2 : MonoBehaviour {
    public Button button;
    public Text buttonText;

    private GameController2 gameController;

    
    public void SetSpace()
    {
        if (gameController.playerMove == true)
        {
            buttonText.text = gameController.GetPlayerSide();
            button.interactable = false;
            gameController.EndTurn();
        }
    } 

    internal void SetGameControllerReference(GameController2 gamecontroller2)
    {
        gameController = gamecontroller2;
    }

    public void SetGameControllerReference(GameController controller)
    {
        throw new NotImplementedException();
    }
}
