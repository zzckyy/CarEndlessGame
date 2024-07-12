using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingLevel : MonoBehaviour
{

    Rigidbody rb;


    public float currentSpeedScroll;
    private float speedScroll;
    public float maxSpeedScroll;

    public float speedProgression = 0.0125f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeedScroll += speedProgression;
        speedScroll = currentSpeedScroll;

        //transform.position = new Vector3(0, 0, speed * Time.fixedDeltaTime);

        rb.velocity = new Vector3(0, 0, speedScroll * Time.deltaTime);

        //transform.position += new Vector3(0, 0, speed * Time.fixedDeltaTime);
        

        if(currentSpeedScroll >= maxSpeedScroll){
            currentSpeedScroll = maxSpeedScroll;
        }

        Debug.Log(currentSpeedScroll);
    }
}
