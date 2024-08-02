using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    public void milihScene(int sceneIndex){
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void keluarGame(){
        Application.Quit();
    }
}