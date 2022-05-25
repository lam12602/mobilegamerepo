using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    //declares object to be used as a target - can be set in unity editor
    public Transform player;
    //sets the delay in movement
    public float dampTime = 0.4f;
    //declares position variables to be altered for the camera
    public Vector3 cameraPos;
    public Vector3 velocity = Vector3.zero;

    void Update()
    {
        // sets the target location for the camera to move to
        cameraPos = new Vector3(player.position.x, player.position.y, -10f);
        // moves the camera if its not at the player location, but with a delay
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime);

    }
}
