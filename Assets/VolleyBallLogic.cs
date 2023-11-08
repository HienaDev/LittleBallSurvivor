using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyBallLogic : MonoBehaviour
{
    [SerializeField] private LayerMask floor;
    [SerializeField] private LayerMask leftTeam;
    [SerializeField] private LayerMask rightTeam;

    public int Team { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == floor.value)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == leftTeam.value)
        {
            Team = 1;
        }   
        if(x == rightTeam.value)
        {
            Team = 2;
        }
    }
}
