using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private KeyCode jump;
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode dropDown;



    [SerializeField] private float speed;
    [SerializeField] private float dropDownForce;
    [SerializeField] private float jumpForce;

    private bool jumpEnabled = true;

    private float defaultGravity;

    private bool isFacingRight = true;

    private bool grounded = false;

    private Animator playerAnim;

    private bool controlsEnabled = true;

    private Rigidbody2D rb;

    Vector2 velocity = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultGravity = rb.gravityScale;
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        velocity = new Vector2(0f, rb.velocity.y);


        if(controlsEnabled)
        { 
            if (Input.GetKeyDown(jump) && jumpEnabled)
            {
                velocity.y = jumpForce;
                jumpEnabled = false;
            }
            if(Input.GetKey(left))
            {
                velocity.x = -speed;
            }
            if (Input.GetKey(right))
            {
                velocity.x = speed;
            }
            if (Input.GetKey(dropDown))
            {
                rb.gravityScale = dropDownForce;
            }
            else
            {
                rb.gravityScale = defaultGravity;
            }
        }

        rb.velocity = velocity;

        if (rb.velocity.y >= -0.1f && rb.velocity.y <= 0.1f) playerAnim.SetFloat("MoveSpeedX", Mathf.Abs(rb.velocity.x));
        else playerAnim.SetFloat("MoveSpeedX", 0f);


        Flip();
    }


    private void Flip()
    {
        if (isFacingRight && rb.velocity.x < 0f || !isFacingRight && rb.velocity.x > 0f)
        {
            isFacingRight = !isFacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }

   


    public void EnableJump() => jumpEnabled = true;

    public void DisableJump() => jumpEnabled = false;

    public void ChangeSpeed(float slowSpeed) => speed = slowSpeed;

    public void ToggleGrounded(bool toggle) => grounded = toggle;

    public bool GetGrounded() => grounded;

    public void ToggleMovement(bool toggle) => controlsEnabled = toggle;
}
