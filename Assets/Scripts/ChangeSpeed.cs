using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{

    [SerializeField] private LayerMask playerMask;
    [SerializeField] private float slowSpeedRatio;
    [SerializeField] private float normalSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;



        // Trigger Clown Falling
        if (x == playerMask.value)
        {
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.ChangeSpeed(normalSpeed * slowSpeedRatio);
            temp.DisableJump();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;



        // Trigger Clown Falling
        if (x == playerMask.value)
        {
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.ChangeSpeed(normalSpeed);

            if(temp.GetGrounded())
                temp.EnableJump();
        }
    }
}
