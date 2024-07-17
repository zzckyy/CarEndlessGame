using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinObj : MonoBehaviour
{       

    public coinSystem _coinSys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
            if(other.tag == "Player")
            {
                _coinSys.currentCoins += 1;
                Debug.Log("coin nambah");

                Destroy(gameObject);
            }
    }
}
