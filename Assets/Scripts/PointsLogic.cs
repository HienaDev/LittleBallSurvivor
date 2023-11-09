using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsLogic : MonoBehaviour
{

    public int Team { get; private set; }   
    public int Player { get; private set; }

    public void GivePlayerNr(int player) => Player = player;
    public void GivePlayerTeam(int team) => Team = team;
}
