using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingSide : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f * -1;
        speed += Time.deltaTime;

        transform.position += new Vector3(0, 0, speed);

        Destroy(gameObject, 3f);
    }
}
