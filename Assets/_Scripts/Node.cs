using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Connections[] possibleLinks;
    public bool isOccupied = false;
    public GameObject occupyingPiece;

    public void SetOccupancy(GameObject go)
    {
        isOccupied = true;
        occupyingPiece = go;

        string pieceTag = occupyingPiece.gameObject.tag;
        
        foreach(Connections conn in possibleLinks)
        {
            Node n1 = conn.linkOne.GetComponent<Node>();
            Node n2 = conn.linkTwo.GetComponent<Node>();

            if(n1.occupyingPiece != null && n2.occupyingPiece != null)
            {
                if(n1.occupyingPiece.tag == pieceTag && n2.occupyingPiece.tag == pieceTag)
                {
                    GameManager.gameManager.EarnPoint();
                }
            }
        }

        GameManager.gameManager.SwitchTurn();
    }

}

[Serializable]
public class Connections
{
    public GameObject thisNode;
    public GameObject linkOne;
    public GameObject linkTwo;
}
