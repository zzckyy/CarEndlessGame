using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinSystem : MonoBehaviour
{
    string coinPrefs;

    public static int coins;
    public static int currentCoins;
    public Text coinUI;
    



    // Start is called before the first frame update
    void Start()
    {
        currentCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinUI.text = currentCoins.ToString();
        PlayerPrefs.SetInt(coinPrefs, coins);

        Debug.Log(currentCoins);
    }
}
