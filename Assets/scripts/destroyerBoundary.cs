using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerBoundary : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Environment"){
            Destroy(other.gameObject);
        }
    }
}
