using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTurnButton : MonoBehaviour
{
    private Touch touch;

    private Turn nextTurn;
    private GameObject _nextTurnObject;
    void Start()
    {

        nextTurn = _nextTurnObject.GetComponent<Turn>();
    }
    void _nextTurn()
    {
        nextTurn.NextTurn();
        
    }
}