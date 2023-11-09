using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class OnLevelLoad : MonoBehaviour
{

    [SerializeField] private UnityEvent startTimer;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Level Loaded");
        Debug.Log(scene.name);
        Debug.Log(mode); 

        startTimer.Invoke();
    }

    public void ActivatePlayers()
    {
        GetComponentInChildren<PlayerCounter>().TogglePlayerControls(true);
    }

    public void StartGame()
    {

        FindAnyObjectByType<GameReset>().Reset();
    }

    public void EndGame()
    {   
        FindAnyObjectByType<GameReset>().GameOver();
    }
}
