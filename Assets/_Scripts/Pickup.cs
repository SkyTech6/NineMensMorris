using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isSelectable = true;
    bool isSelected = false;
    private Node nodePosition;
    public bool isOnBoard() { if (nodePosition != null) return true; else return false; }

    void Update()
    {
        if (isSelected)
        {
            Vector3 position = MousePositional.mouse.GetPosition();
            transform.position = new Vector3(position.x, 0.624f, position.z);
        }
    }

    void OnMouseDown()
    {
        if(GameManager.gameManager.removalPhase > 0)
        {
            if(!isOnBoard())
                return;
                
            if(GameManager.gameManager.currentPlayerTurn == 0 && this.gameObject.tag != "piece-white")
            {
                GameManager.gameManager.removalPhase--;
                nodePosition.occupyingPiece = null;
                Destroy(this.gameObject);
            }
            else if(GameManager.gameManager.currentPlayerTurn == 1 && this.gameObject.tag != "piece-black")
            {
                GameManager.gameManager.removalPhase--;
                nodePosition.occupyingPiece = null;
                Destroy(this.gameObject);
            }
        }

        if (isSelected)
        {
            if (PiecePlacement.manager.isPlaceable)
            {
                isSelected = false;
                nodePosition = PiecePlacement.manager.placeablePosition;
                PiecePlacement.manager.placeablePosition.SetOccupancy(this.gameObject);
            }
        }
        else
        {
            if (!isSelectable)
                return;

            isSelected = true;
            PiecePlacement.manager.pieceToPlace = this.gameObject;

            if (nodePosition != null)
            {
                nodePosition.occupyingPiece = null;
                nodePosition = null;
            }
        }
    }
}
