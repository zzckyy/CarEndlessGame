using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSystem : MonoBehaviour
{

    public int coins;
    public int currentCoins;



    // Start is called before the first frame update
    void Start()
    {
        currentCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        Debug.Log(currentCoins);
    }
}
