using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Connections[] possibleLinks;
    public bool isOccupied = false;
    public GameObject occupyingPiece;

    void Start()
    {

    }

    void Update()
    {

    }
}

[Serializable]
public class Connections
{
    public GameObject thisNode;
    public GameObject linkOne;
    public GameObject linkTwo;
}
