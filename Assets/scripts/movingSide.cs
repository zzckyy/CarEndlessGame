using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingSide : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 1.7f * -1;
        speed += Time.deltaTime;

        transform.position += new Vector3(0, 0, speed);

        Destroy(gameObject, 3f);
    }
}
