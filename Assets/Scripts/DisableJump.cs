using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableJump : MonoBehaviour
{

    [SerializeField] private LayerMask playerMask;
    [SerializeField] private LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == playerMask.value || x == groundMask.value)
        {
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.EnableJump();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == playerMask.value || x == groundMask.value)
        {
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.ToggleGrounded(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;


        if (x == playerMask.value || x == groundMask.value)
        {
            
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.ToggleGrounded(false);
        }
    }
}

