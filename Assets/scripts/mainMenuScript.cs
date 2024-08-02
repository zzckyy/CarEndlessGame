using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuScript : MonoBehaviour
{
    public Slider volumeSlider; 
    public AudioMixer _mixer;

    void Start(){
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.9f);
    }

    public void milihScene(int sceneIndex){
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void keluarGame(){
        Application.Quit();
        Debug.Log("game keluar");
    }

    public void volumeController(string targetMixer){
        float _volume = volumeSlider.value;
        _mixer.SetFloat(targetMixer, Mathf.Log10(_volume)*20);
        PlayerPrefs.SetFloat("MusicVolume", _volume);
    }

    public void waktuField(float variabelWaktu){
        Time.timeScale = variabelWaktu;
    }
}