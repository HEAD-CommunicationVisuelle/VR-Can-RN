using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Play a sound whem a collision is detected
public class BounceSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detect collision
    void OnCollisionEnter(Collision collision)
    {
        //Play a Sound
        GetComponent<AudioSource>().Play();
    }

}
