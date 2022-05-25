using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //kill player

    public void kill()
    {
        //Destroy object
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
