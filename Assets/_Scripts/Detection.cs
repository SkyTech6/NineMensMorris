using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "piece-black" || collider.tag == "piece-white")
        {
            PiecePlacement.manager.placeablePosition = this.gameObject.GetComponent<Node>();
            PiecePlacement.manager.isPlaceable = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        PiecePlacement.manager.placeablePosition = null;
        PiecePlacement.manager.isPlaceable = false;
    }
}
