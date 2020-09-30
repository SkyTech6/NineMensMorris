using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    //player 0 = white
    //player 1 = black
    public int currentPlayerTurn = 0;
    public PlayerHandler[] players;

    void Start()
    {
        if(gameManager == null)
            gameManager = this;
        else
            Destroy(this);

        foreach(PlayerHandler player in players)
        {
            player.SetPieces(false);
        }

        currentPlayerTurn = Random.Range(0, 2);
        SwitchTurn();
    }
    
    public void SwitchTurn()
    {
        if(currentPlayerTurn == 1)
        {
            currentPlayerTurn = 0;
            players[1].SetPieces(false);
            players[0].SetPieces(true);
        } 
        else
        {
            currentPlayerTurn = 1;
            players[1].SetPieces(true);
            players[0].SetPieces(false);
        }     
    }
}
