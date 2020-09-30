using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecePlacement : MonoBehaviour
{
    public static PiecePlacement manager;
    public bool isPlaceable = false;
    public GameObject pieceToPlace;
    public Node placeablePosition;

    void Start()
    {
        if(manager == null)
            manager = this;
        else
            Destroy(this);
    }
}
