using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelPickup : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
            if(other.tag == "Player")
            {
                fuelSystem.fuelValue += fuelSystem.fuelPickupValue;
                Destroy(gameObject);
            }
    }

}
