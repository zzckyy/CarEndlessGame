using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public Text scoreText;
    public string textHUD;

    private float scoreVar = 1;
    private int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        scoreVar += Time.deltaTime;

        currentScore =  Convert.ToInt32(scoreVar);

        scoreText.text = textHUD + currentScore.ToString();


        Debug.Log(currentScore);
    }
}
