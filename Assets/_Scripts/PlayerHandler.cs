using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public GameObject[] sidePieces;

    public void SetPieces(bool enable)
    {
        Debug.Log("Setting pieces to " + enable);
        foreach(GameObject go in sidePieces)
        {
            go.GetComponent<Pickup>().isSelectable = enable;
        }
    }
}
