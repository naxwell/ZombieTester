using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRattler : MonoBehaviour
{
    public bool rattling;
    public Rigidbody rb;
    public float thrust = 50f;
    public float waitTime;
    public float min = 5f;
    public float max = 10f;
    // Start is called before the first frame update

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Invoke ("Rattle", (UnityEngine.Random.Range(min, max)));
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
      

    }

    void Rattle()
    {
        waitTime = UnityEngine.Random.Range(min, max);
        rb.AddForce(transform.forward * thrust);

        Invoke("Rattle", waitTime);
         
    }

}
