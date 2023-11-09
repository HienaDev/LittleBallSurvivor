using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameHost : MonoBehaviour
{

    [SerializeField] private string[] games;

    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject pressurePlate;

    //[SerializeField] private UnityEvent timerStartGame;

    private string game;

    public bool GameRunning { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        GameRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(games);
    }

    public void GameRunningToggle(bool toggle) => GameRunning = toggle;

    public void StartRandomGame()
    {

        game = games[Random.Range(0, games.Length)];


        SceneManager.LoadScene(game);
    }


}
