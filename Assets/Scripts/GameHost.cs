using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameHost : MonoBehaviour
{

    [SerializeField] private Scene[] games;

    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject floorCollider;
    [SerializeField] private GameObject menuCollider;
    [SerializeField] private GameObject pressurePlate;

    [SerializeField] private UnityEvent timerStartGame;

    private Scene game;

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

    public void TriggerRandomGame()
    {
        menuUI.SetActive(false);
        menuCollider.SetActive(false);
        pressurePlate.SetActive(false);

        
        floorCollider.SetActive(true);



        timerStartGame.Invoke();

        //Timer.SetTimerOffset(Time.time);



        game = games[Random.Range(0, games.Length)];

    }

    public void GameRunningToggle(bool toggle) => GameRunning = toggle;

    public void StartGame()
    {

        Timer.SetTimerOffset(Time.time);

        SceneManager.LoadScene(game.name);
    }


}
