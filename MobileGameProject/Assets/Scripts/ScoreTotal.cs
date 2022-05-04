using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTotal : MonoBehaviour
{
    private int scoreValue = 0;
    public Text scoreDisplay;
    public void AddScore(int tooAdd)
    {
        scoreValue += tooAdd;

        scoreDisplay.text = scoreValue.ToString();

    }



    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
