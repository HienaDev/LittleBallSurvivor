using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayersAndChangeMovement : MonoBehaviour
{

    private PlayerCounter playerManager;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = FindAnyObjectByType<PlayerCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePlayerMovement(bool toggle)
    {
        playerManager.TogglePlayerControls(toggle);
    }
}
