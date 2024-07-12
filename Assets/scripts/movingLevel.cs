using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingLevel : MonoBehaviour
{
    Renderer rend;
    float offset_x = 0;
    public float speedBG;
    
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
        

        
        //endless with material
        offset_x += speedBG * -1 * Time.deltaTime;

        rend.material.SetTextureOffset("_BaseMap", new Vector2(offset_x, 0));
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
