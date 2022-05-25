using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class BasicMovementEnemy : MonoBehaviour
{
    

    public float moveSpeed = 3;

    private Rigidbody2D physicsBody = null;

    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

        physicsBody.velocity = new Vector2(-2,0);
        
    }

    
}
