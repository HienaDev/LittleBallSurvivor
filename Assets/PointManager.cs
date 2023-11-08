using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int Player1Points { get; private set; }
    public int Player2Points { get; private set; }
    public int Player3Points { get; private set; }
    public int Player4Points { get; private set; }

    [SerializeField] private TMP_Text player1PointsUI;
    [SerializeField] private TMP_Text player2PointsUI;
    [SerializeField] private TMP_Text player3PointsUI;
    [SerializeField] private TMP_Text player4PointsUI;

    private void Start()
    {
        Player1Points = 0;
        Player2Points = 0;
        Player3Points = 0;
        Player4Points = 0;

        UpdatePlayerPoints();
    }

    public void GivePlayerPoints(int player)
    {
        if (player == 1)
            Player1Points++;

        if (player == 2)
            Player2Points++;

        if (player == 3)
            Player3Points++;

        if (player == 4)
            Player4Points++;

        UpdatePlayerPoints();
    }

    private void UpdatePlayerPoints()
    {
        player1PointsUI.text = Player1Points.ToString();
        player2PointsUI.text = Player2Points.ToString();
        player3PointsUI.text = Player3Points.ToString();
        player4PointsUI.text = Player4Points.ToString();
    }
}
