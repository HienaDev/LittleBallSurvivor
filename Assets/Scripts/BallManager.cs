using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : Game
{

    public override void Reset()
    {
        Debug.Log("ASJDHGAJ!!");
        foreach (Transform child in transform) { Destroy(child.gameObject); }

    }
}
