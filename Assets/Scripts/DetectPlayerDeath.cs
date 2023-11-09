using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerDeath : MonoBehaviour
{

    [SerializeField] private LayerMask ballMask;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int x = 1 << collision.gameObject.layer;



        // Trigger Clown Falling
        if (x == ballMask.value)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        
    }
}
