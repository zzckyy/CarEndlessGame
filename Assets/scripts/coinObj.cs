using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinObj : MonoBehaviour
{       

    //public coinSystem _coinSys;


    // Start is called before the first frame update
    void Start()
    {
        //cs = GameObject.Find("CoinSYS").GetComponent<coinSystem>();

        //coinSystem cs = FindObjectsOfType<coinSystem>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
            if(other.tag == "Player")
            {
                coinSystem.currentCoins += 1;
                Debug.Log("coin nambah");

                Destroy(gameObject);
            }
    }
}
