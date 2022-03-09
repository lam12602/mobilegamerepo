using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public string message = "default";
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(message);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Big downs");
    }
}
