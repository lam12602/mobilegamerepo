using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionChecker : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //thing we ran into
        GameObject othherObject = collision.gameObject;

        //gets the name of the object
        string otherName = othherObject.name;

        //check the tag on the object
        string otherTag = othherObject.tag;

        //we can get sorting layer of the obeject
        int layer = othherObject.layer;

        //we canm check if a script is on the object
        //getting a componetnt
        SpriteRenderer spriteRenderer = othherObject.GetComponent<SpriteRenderer>();

        Debug.Log("Collison");
        Debug.Log("Name" + otherName);
        Debug.Log("Tag" + otherTag);
        if(spriteRenderer != null)
        {
            spriteRenderer.color = Color.green;
        }
        

    }
}
