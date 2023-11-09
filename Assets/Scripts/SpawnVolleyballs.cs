using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVolleyballs : MonoBehaviour
{

    private bool readyToSpawn = true;

    private GameObject ballManager;


    [SerializeField] private GameObject ballPrefab;

    [SerializeField] private GameObject[] spawner;

    private GameObject volleyBall;

    // Start is called before the first frame update
    void Start()
    {
        ballManager = FindAnyObjectByType<VolleyBallManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (readyToSpawn)
        {
            readyToSpawn = false;
            volleyBall = Instantiate(ballPrefab, spawner[Random.Range(0, 4)].transform.position, Quaternion.identity, ballManager.transform);
        }
    }

    public void ToggleReadyToSpawn(bool toggle) => readyToSpawn = toggle;

}


