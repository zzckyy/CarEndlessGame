using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingSide : MonoBehaviour
{

    public float speed = -1.7f;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        speed -= Time.deltaTime;

        transform.position += new Vector3(0, 0, speed);

        Destroy(gameObject, 3f);
    }
}
