using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string targetScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //we overlapped
        //check if player
        if (collision.CompareTag("Player"))
        {
            //its the player

            //action change scene
            SceneManager.LoadScene(targetScene);
        }
    }
}
