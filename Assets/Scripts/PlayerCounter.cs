using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCounter : MonoBehaviour
{

    private bool player1Here;
    private bool player2Here;
    private bool player3Here;
    private bool player4Here;

    [SerializeField] private GameObject player1Prefab;
    [SerializeField] private GameObject player2Prefab;
    [SerializeField] private GameObject player3Prefab;
    [SerializeField] private GameObject player4Prefab;

    private List<GameObject> playerList = new List<GameObject>();

    public int NrOfPlayers { get; private set; }

    [SerializeField] private GameObject hyenaUI;
    [SerializeField] private GameObject bunnyUI;
    [SerializeField] private GameObject batUI;
    [SerializeField] private GameObject penguinUI;


    private int playerNumber = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !player1Here)
        {
            player1Here = true;
            AddPlayerCounter();

            hyenaUI.SetActive(true);

            GameObject player = Instantiate(player1Prefab, gameObject.transform);

            playerList.Add(player);

            player.GetComponent<PointsLogic>().GivePlayerNr(playerNumber);
            playerNumber++;

  
        }

        if (Input.GetKeyDown(KeyCode.I) && !player2Here)
        {
            
            player2Here = true;
            AddPlayerCounter();

            bunnyUI.SetActive(true);

            GameObject player = Instantiate(player2Prefab, gameObject.transform);

            playerList.Add(player);

            player.GetComponent<PointsLogic>().GivePlayerNr(playerNumber);
            playerNumber++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !player3Here)
        {
            
            player3Here = true;
            AddPlayerCounter();

            batUI.SetActive(true);

            GameObject player = Instantiate(player3Prefab, gameObject.transform);

            playerList.Add(player);

            player.GetComponent<PointsLogic>().GivePlayerNr(playerNumber);
            playerNumber++;
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) && !player4Here)
        {
            
            player4Here = true;
            AddPlayerCounter();

            penguinUI.SetActive(true);

            GameObject player = Instantiate(player4Prefab, gameObject.transform);

            playerList.Add(player);

            player.GetComponent<PointsLogic>().GivePlayerNr(playerNumber);
            playerNumber++;
        }
    }

    private void AddPlayerCounter()
    {
       
        NrOfPlayers += 1;

    }

    public void TogglePlayerControls(bool toggle)
    {
        foreach(GameObject player in playerList)
        {
            if(player.activeSelf)
                player.GetComponent<PlayerMovement>().ToggleMovement(toggle);
        }
    }

    public void ActivatePlayers()
    {
        foreach (GameObject player in playerList)
        {
            if (!player.activeSelf)
                player.SetActive(true);
        }
    }

    public List<GameObject> GetPlayerList() => playerList;
}
