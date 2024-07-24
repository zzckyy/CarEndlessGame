using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiSpawner : MonoBehaviour
{
    public float spawnRate;
    public GameObject[] objTarget = new GameObject[2];
    public Transform[] locationTarget;

    void Start()
    {
        InvokeRepeating("mulSpawn", 3f, spawnRate);
    }


    void mulSpawn()
    {
        int objTargetList = Random.Range(0, objTarget.Length);
        int locationTargetList = Random.Range(0, locationTarget.Length);

        //Debug.Log("hh");

        Instantiate(
                objTarget[objTargetList],
                //new Vector3(Random.Range(min, max), transform.position.y, 0f)
                locationTarget[locationTargetList].position,
                objTarget[objTargetList].transform.rotation
            );

    }
}
