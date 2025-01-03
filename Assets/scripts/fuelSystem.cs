using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelSystem : MonoBehaviour
{

    //variabel untuk bensin
    public static float fuelValue;

    //menambah nilai ketika mendapat bensin
    public static float fuelPickupValue;
    public float fuelPickupValueInspector;
    public Slider fuelUI;
    public GameObject LowFuelUI;
    public float bensinDecreaseRate;
    public static float bensinKecepatan;

    public float bensinKecepatanInspector;

    // Start is called before the first frame update
    void Start()
    {
        fuelValue = 100;
        LowFuelUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        bensinKecepatan = bensinKecepatanInspector;
        fuelPickupValue = fuelPickupValueInspector;

        fuelValue -= bensinDecreaseRate * Time.deltaTime;

        //int fuelInt = Convert.ToInt32(fuelValue);
        Debug.Log("full value: " + fuelValue);

        fuelUI.value = fuelValue;

        if(fuelValue <= 0){
            fuelValue = 0;
            gameManager.isGameOver = true;
        }
        if(fuelValue >= 100){
            fuelValue = 100;
        }

        else if(fuelValue <= 25){
            LowFuelUI.SetActive(true);
        }
        else{
            LowFuelUI.SetActive(false);
        }
        
    }
}
