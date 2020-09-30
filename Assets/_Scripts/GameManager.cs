using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    //player 0 = white
    //player 1 = black
    public int currentPlayerTurn = 0;
    public PlayerHandler[] players;
    public TMP_Text currentTurn;
    public TMP_Text whiteScore;
    public TMP_Text blackScore;
    public int white;
    public int black;

    public int removalPhase = 0;

    void Start()
    {
        if (gameManager == null)
            gameManager = this;
        else
            Destroy(this);

        foreach (PlayerHandler player in players)
        {
            player.SetPieces(false);
        }

        currentPlayerTurn = Random.Range(0, 2);
        SwitchTurn();
    }

    public void SwitchTurn()
    {
        StartCoroutine(WaitForSwitch());
    }

    IEnumerator WaitForSwitch()
    {
        while (removalPhase > 0)
            yield return null;

        if (currentPlayerTurn == 1)
        {
            currentTurn.text = "WHITE";
            currentPlayerTurn = 0;
            players[1].SetPieces(false);
            players[0].SetPieces(true);
        }
        else
        {
            currentTurn.text = "BLACK";
            currentPlayerTurn = 1;
            players[1].SetPieces(true);
            players[0].SetPieces(false);
        }
    }

    public void EarnPoint()
    {
        removalPhase++;
        if (currentPlayerTurn == 0)
        {
            white++;
            whiteScore.text = "White: " + white;
        }
        else
        {
            black++;
            blackScore.text = "Black: " + black;
        }
    }
}
