using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    private TMP_Text text;
    public static float timeOffset = 0f;

    private bool timerRunning = false;
    private float countdown = 30f;

    [SerializeField] private UnityEvent actionAfterTimer;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Mathf.FloorToInt((countdown) % 60).ToString().Length > 1)
            text.text = "0" + Mathf.FloorToInt((countdown) / 60).ToString() + ":" + Mathf.FloorToInt((countdown) % 60).ToString();
        else
            text.text = "0" + Mathf.FloorToInt((countdown) / 60).ToString() + ":0" + Mathf.FloorToInt((countdown) % 60).ToString();

        if(timerRunning)
        { 
            countdown -= Time.deltaTime;
        }

        if(countdown <= 0.2 && timerRunning)
        {
            timerRunning = false;
            actionAfterTimer.Invoke();
        }
    }

    public static void SetTimerOffset(float time) => timeOffset = time;

    public void StartTimer(float time)
    {
        countdown = time + 0.5f;
        timerRunning = true;
    }

    public void StopTimer() => timerRunning = false;

    public bool GetTimerRunning() => timerRunning;

    public void ToggleText(bool toggle) => gameObject.SetActive(toggle);
    
}
