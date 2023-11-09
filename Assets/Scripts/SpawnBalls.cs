using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{

    [SerializeField] private float timeToSpawn;
    private float justSpawned;
    private bool readyToSpawn = false;

    private GameObject ballManager;
    

    [SerializeField] private GameObject ballPrefab;

    [SerializeField] private GameObject[] spawner;

    private float offset;

    // Start is called before the first frame update
    void Start()
    {
        ballManager = FindAnyObjectByType<BallManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time - offset);
        if ((Time.time - offset) - justSpawned > timeToSpawn && readyToSpawn)
        {
            GameObject temp = Instantiate(ballPrefab, spawner[Random.Range(0,4)].transform.position, Quaternion.identity, ballManager.transform);
            justSpawned = Time.time - offset;
        }
    }

    public void ToggleReadyToSpawn(bool toggle) => readyToSpawn = toggle;

    public void StartGame()
    {
        
        offset = Time.time;

        ToggleReadyToSpawn(true);
    }

    public void StopGame()
    {
        ToggleReadyToSpawn(false);

        foreach (Transform child in ballManager.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
