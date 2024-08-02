using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    public float speedInspector;

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = speedInspector * -1;
        //speed += Time.deltaTime;

        transform.position += new Vector3(0, 0, speed);

        Destroy(gameObject, 8f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("game over");
            gameManager.isGameOver = true;
        }
    }
}
