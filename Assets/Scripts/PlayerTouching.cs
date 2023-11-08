using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTouching : MonoBehaviour
{

    [SerializeField] private LayerMask playerMask;

    [SerializeField] private UnityEvent startGame;
    [SerializeField] private UnityEvent stopTimer;

    [SerializeField] private GameObject timer;
    private Timer timerScript;

    [SerializeField] private PlayerCounter playerCounter;

    // Start is called before the first frame update
    void Start()
    {
        timerScript = timer.GetComponent<Timer>();
    }

    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == playerMask.value && !timerScript.GetTimerRunning() && playerCounter.NrOfPlayers > 1)
        {
            timer.SetActive(true);
            startGame.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == playerMask.value && timerScript.GetTimerRunning())
        {
            timer.SetActive(false);
            stopTimer.Invoke();
        }
    }

    //private void ToggleColliderCheck(bool toggle) => colliderCheck = toggle;

    //private bool GetColliderCheck() => colliderCheck;

}
