using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowTrigger : MonoBehaviour
{
    public float PenguranganSpeed;
    public movingLevel[] _level;
    // public  movingSide _mside;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Player")
        {
            _level[0].speedBG -= PenguranganSpeed;
            // _mside.speed += PenguranganSpeed;
            Destroy(gameObject);
        }
    }
}
