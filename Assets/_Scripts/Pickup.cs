using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isSelectable = true;
    bool isSelected = false;

    void Update()
    {
        if(isSelected)
        {
            Vector3 position = MousePositional.mouse.GetPosition();
            transform.position = new Vector3(position.x, 0.624f, position.z);
        }
    }

    void OnMouseDown()
    {
        if(isSelected)
        {
            if(PiecePlacement.manager.isPlaceable)
            {
                isSelected = false;
                PiecePlacement.manager.placeablePosition.SetOccupancy(this.gameObject);
            }   
        }
        else
        {
            if(!isSelectable)
                return;
        
            isSelected = true;
            PiecePlacement.manager.pieceToPlace = this.gameObject;
        }
    }
}
