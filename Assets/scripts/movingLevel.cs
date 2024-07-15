using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingLevel : MonoBehaviour
{
    Renderer rend;
    float offset_x = 0;
    public float speedBG;

    float currentSpeed;
    public float maxSpeed;
    
    /*
    Rigidbody rb;


    public float currentSpeedScroll;
    private float speedScroll;
    public float maxSpeedScroll;

    public float speedProgression = 0.0125f;
    */


    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float scroll;
        
        //endless with material
        scroll = offset_x += speedBG * -1 * Time.deltaTime;

        speedBG += .02f * Time.deltaTime;

        rend.material.SetTextureOffset("_BaseMap", new Vector2(scroll, 0));

        if(speedBG >= maxSpeed){
            speedBG = maxSpeed;
            
        }

        //Debug.Log(speedBG);
    }

    /*
    public void endlessRoadRigidbody()
    {   
        currentSpeedScroll += speedProgression;
        speedScroll = currentSpeedScroll;

        rb.velocity = new Vector3(0, 0, speedScroll * -1 * Time.deltaTime);
        

        if(currentSpeedScroll >= maxSpeedScroll){
            currentSpeedScroll = maxSpeedScroll;
            
        }

        //Debug.Log(currentSpeedScroll);
        
    } */


}
