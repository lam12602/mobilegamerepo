using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3;
    
    private Rigidbody2D physicsBody = null;


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
}
