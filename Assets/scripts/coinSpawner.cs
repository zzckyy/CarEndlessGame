using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{

    public GameObject coinObject;
    public float coinRateSpawn;

    private float minCoinSpawnPoint;
    private float maxCoinSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 3f,coinRateSpawn);
    }

    void SpawnCoin()
    {
        Instantiate(
                coinObject,
                new Vector3(Random.Range(minCoinSpawnPoint, maxCoinSpawnPoint), transform.position.y, transform.position.z),
                Quaternion.identity
            );
    }
}
