using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickUp : MonoBehaviour
{
    public int pickupValue = 10;
    //called by unity when this object overlaps with another
    //this is a condition
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //we only want to do anythiong if other object is player

        //will check for the score total scripts
        ScoreTotal scoreToatalScript = collision.GetComponent<ScoreTotal>();

        //check if we found scoretotal script is on other object
        if(scoreToatalScript != null)
        {
            //this means the object was the player and we can add score

            //we should add to the score
            scoreToatalScript.AddScore(pickupValue);
            Destroy(gameObject);
        }
    }
}
