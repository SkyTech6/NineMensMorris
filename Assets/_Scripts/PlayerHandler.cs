using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public List<GameObject> sidePieces;
    public List<GameObject> piecesOnBoard;

    public void SetPieces(bool enable)
    {
        if (sidePieces.Count == 0)
        {
            piecesOnBoard.TrimExcess();
            foreach (GameObject go in piecesOnBoard)
                go.GetComponent<Pickup>().isSelectable = enable;
        }
        else
        {
            List<GameObject> toRemove = new List<GameObject>();
            foreach (GameObject go in sidePieces)
            {
                if (go.GetComponent<Pickup>().isOnBoard())
                {
                    piecesOnBoard.Add(go);
                    toRemove.Add(go);
                }
                
                go.GetComponent<Pickup>().isSelectable = enable;
            }

            foreach(GameObject go in toRemove)
                sidePieces.Remove(go);

            sidePieces.TrimExcess();
        }
    }
}
