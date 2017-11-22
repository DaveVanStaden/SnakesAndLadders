using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour {
    private int turn = 1;
    public Text turnText;
    public void Update()
    {
        if (turn == 1)
        {
            turnText.text = "Player 1's turn!";
        }
        if (turn == 2)
        {
            turnText.text = "Player 2's turn!";
        }
        if (turn == 3)
        {
            turnText.text = "Player 3's turn!";
        }
        if (turn == 4)
        {
            turnText.text = "Player 4's turn!";
        }
    }
    public void NextTurn()
    {
        turn++;
        if (turn >4)
        {
            turn = 1;

        }
        Debug.Log(turn);
    }
    public int GetTurn()
    {
        return turn;
    }
}
