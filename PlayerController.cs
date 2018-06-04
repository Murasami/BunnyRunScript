using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed, JumpForce;
    private Rigidbody2D player;

    public float jumpTime;
    private float jumpTimeCounter;

    private bool stoppedJumping;
    private bool canDoubleJump;

    public bool ground;
    public LayerMask whatIsGround;

    private Collider2D mycollider;
    private Animator playerMove;
    public AudioSource jumpSound;
    // Use this for initialization
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        mycollider = GetComponent<Collider2D>();
        playerMove = GetComponent<Animator>();
        jumpTimeCounter = jumpTime;
        stoppedJumping = true;
    }

    // Update is called once per frame
    void Update()
    {
        ground = Physics2D.IsTouchingLayers(mycollider, whatIsGround); //if player touch the ground 
        player.velocity = new Vector2(moveSpeed, player.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ground)
            {
                player.velocity = new Vector2(player.velocity.x, JumpForce);
                stoppedJumping = false;
                jumpSound.Play();
            }
            if (!ground && canDoubleJump)
            {
                player.velocity = new Vector2(player.velocity.x, JumpForce);
                jumpTimeCounter = jumpTime;
                stoppedJumping = false;
                canDoubleJump = false;
                jumpSound.Play();
            }
        }
        if (Input.GetKey(KeyCode.Space) && !stoppedJumping)
        {
            if (jumpTimeCounter > 0)
            {
                player.velocity = new Vector2(player.velocity.x, JumpForce);
                jumpTimeCounter -= Time.deltaTime; //while jump time count down
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }
        if (ground)
        {
            jumpTimeCounter = jumpTime;
            canDoubleJump = true;
        }

        playerMove.SetFloat("Speed", player.velocity.x);
        playerMove.SetBool("Ground", ground);
    }
}




