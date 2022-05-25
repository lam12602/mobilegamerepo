using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3;
    private readonly float jumpVelocity = 10f;

    private bool isGrounded = true;
    // sets multipliers for the jump and fall speeds
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public Rigidbody2D physicsBody = null;


    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        //physicsBody.velocity = new Vector2(2,0);
    }

    // Update is called once per frame
    void Update()
    {
        //ask unity for current value for hori axis
        float axisVal = Input.GetAxis("Horizontal");
        Vector2 newVel = new Vector2(axisVal, 0);
        newVel = newVel * moveSpeed;
        //physicsBody.velocity = newVel;
    }
    public void MoveLeft()
    {
        Debug.Log("Moveleft pressed");
        Vector2 newVel = new Vector2(-moveSpeed, 0);
        physicsBody.velocity = newVel;
    }
    public void MoveRight()
    {
        Debug.Log("MoveRight pressed");
        Vector2 newVel = new Vector2(moveSpeed, 0);
        physicsBody.velocity = newVel;

    }
    
    public void Jump()
    {
        if ( isGrounded)
        {

            physicsBody.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
        // sets the multiplier when you start jumping
        if (physicsBody.velocity.y < 0)
        {
            physicsBody.velocity += (fallMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
        // sets the multiplier if falling so that you fall faster
        else if (physicsBody.velocity.y > 0 && Input.GetKey(KeyCode.Space))
        {
            physicsBody.velocity += (lowJumpMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
    }
        //checks for collision, if hits someting, will mark as "grounded" allowing for another jump
        private void OnCollisionEnter2D(Collision2D collision)
    {
            isGrounded = true;
    }
    }

