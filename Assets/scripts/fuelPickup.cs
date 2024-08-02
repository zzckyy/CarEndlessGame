using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelPickup : MonoBehaviour
{

    void FixedUpdate(){
        float rotateSpeed = 3f;
        transform.Rotate(0f, 0f, rotateSpeed);


        float speed = fuelSystem.bensinKecepatan * -1;
        //speed += Time.deltaTime;

        transform.position += new Vector3(0, 0, speed);

        Destroy(gameObject, 12f);
    }
    public void OnTriggerEnter(Collider other)
    {
            if(other.tag == "Player")
            {
                fuelSystem.fuelValue += fuelSystem.fuelPickupValue;
                Destroy(gameObject);
            }
    }

}
