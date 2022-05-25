using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script will kill the player when they touch this object

public class Hazzard : MonoBehaviour
{

    //get health component


    void OnCollisionEnter2D(Collision2D collisionData)
    {
        // Get the object we collided with
        Collider2D objectWeCollidedWith = collisionData.collider;

        // Get the PlayerHealth script attached to that object (if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

        // Check if we actually found a player health script
        // This if statement is true if the player variable is NOT null (empty)
        if (player != null)
        {
            // This means there WAS a PlayerHealth script attached to the object we bumped into
            // Which means this object is indeed the player

            // Perform our on-collision action (kill the player)
            player.kill();
        }
    }
}
