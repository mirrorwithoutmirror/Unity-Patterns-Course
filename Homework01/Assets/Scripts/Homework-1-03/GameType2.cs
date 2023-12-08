using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameType2 : iGameType
{
    public void CheckWinCondition(Main_1_3 main)
    {
        main.choosedBalls.Add(main.selectedBall);
        if (AllElementsHaveSameColors(main.choosedBalls) && !CheckIfListHasColor(main.balls, main.choosedBalls[0].GetComponent<Ball>().color))
        {
            Debug.Log("You win!");
            main.isPlaying = false;
        }
        else if (!AllElementsHaveSameColors(main.choosedBalls))
        {

            Debug.Log("You lose!");
            main.isPlaying = false;
        }
    }

    private bool AllElementsHaveSameColors(List<GameObject> gameObjectList)
    {
        if (gameObjectList.Count > 0)
        {
            ColorType referenceColor = gameObjectList[0].GetComponent<Ball>().color;

            for (int i = 1; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i].GetComponent<Ball>().color != referenceColor)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool CheckIfListHasColor(List<GameObject> gameObjectList, ColorType color)
    {
        if (gameObjectList.Count > 0)
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i].GetComponent<Ball>().color == color)
                {
                    return true;
                }
            }
            return false;
        }
        else
        {
            return false;
        }
    }
}
