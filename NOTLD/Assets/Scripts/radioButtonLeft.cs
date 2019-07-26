using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioButtonLeft : MonoBehaviour
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
        radio.minusTrack();
    }

 
}
