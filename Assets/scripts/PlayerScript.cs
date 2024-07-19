using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody _rb;

    public AudioSource audioKlakson; 
    public AudioClip clipKlakson;

    public float hSpeed;
    public float vSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        _rb.velocity = new Vector3 (Input.GetAxis("Horizontal") * hSpeed, _rb.velocity.y * 0, Input.GetAxis("Vertical") * vSpeed);


        if(Input.GetButtonDown("")){
            audioKlakson.PlayOneShot(clipKlakson);
        }
    }
}
