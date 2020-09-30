using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //player 0 = white
    //player 1 = black
    public int currentPlayerTurn = 0;

    void Start()
    {
        currentPlayerTurn = Random.Range(0, 2);
    }
    
    void SwitchTurn()
    {
        if(currentPlayerTurn == 1)
            currentPlayerTurn = 0;
        else
            currentPlayerTurn = 1;
    }
}
