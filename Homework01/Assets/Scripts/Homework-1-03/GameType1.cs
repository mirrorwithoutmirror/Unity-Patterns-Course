using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameType1 : iGameType
{
    public void CheckWinCondition(Main_1_3 main)
    {
        if (main.balls.Count == 0)
        {
            Debug.Log("You win!");
        }
    }
}
