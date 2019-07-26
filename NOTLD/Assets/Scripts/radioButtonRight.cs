using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioButtonRight : MonoBehaviour
{
    public radioTuner radio;
   

 
    void Start()
    {
       
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
       
        radio.plusTrack();
    }


}