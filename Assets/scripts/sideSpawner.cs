using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideSpawner : MonoBehaviour
{
    public GameObject[] objectModel = new GameObject[3];
    public Transform[] spawnLoc;

    public float voke;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSide", 3, voke);
    }
    // Update is called once per frame
    void Update()
    {
        int objectList = Random.Range(0, objectModel.Length);
        int spawnList = Random.Range(0, spawnLoc.Length);


        

       /* if (Input.GetButtonDown("Fire3")){
            Instantiate(
                objectModel[objectList],
                //new Vector3(Random.Range(min, max), transform.position.y, 0f)
                spawnLoc[spawnList].position,
                objectModel[objectList].transform.rotation
            );

        }*/
        
            
    }

    void spawnSide()
    {
        int objectList = Random.Range(0, objectModel.Length);
        int spawnList = Random.Range(0, spawnLoc.Length);

        //Debug.Log("hh");

        Instantiate(
                objectModel[objectList],
                //new Vector3(Random.Range(min, max), transform.position.y, 0f)
                spawnLoc[spawnList].position,
                objectModel[objectList].transform.rotation
            );

    }
}
