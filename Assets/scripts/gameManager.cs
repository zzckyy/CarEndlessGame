using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public Text scoreText;
    public string textHUD;

    private float scoreVar = 1;
    private int currentScore;

    public static bool isGameOver;

    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        Time.timeScale = 1f;

        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        scoreVar += Time.deltaTime;

        currentScore =  Convert.ToInt32(scoreVar);

        scoreText.text = textHUD + currentScore.ToString();


        //Debug.Log(currentScore);
        
    }

    void Update(){
        if(isGameOver == true){
            gameOver();
        }
    }

    public void gameOver(){
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void gantiScene(int sceneIndex){
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}
