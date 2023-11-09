using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameReset : Game
{

    [SerializeField] private UnityEvent gameStart;
    [SerializeField] private UnityEvent gameOver;


    private void Awake()
    {

    }

    public override void Reset()
    {
        Debug.Log(gameObject.name + " started!");
        gameStart.Invoke();
    }

    public override void GameOver()
    {
        Debug.Log(gameObject.name + " ended!");
        gameOver.Invoke();
    }

}
