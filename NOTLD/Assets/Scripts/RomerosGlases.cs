using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class RomerosGlases : MonoBehaviour
{

    public bool isGrabbed = false;
    public PostProcessVolume glasses;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrabbed = GetComponent<OVRGrabbable>().isGrabbed;

        if (isGrabbed)
        {
            glasses.enabled = true;
        } else
        {
            glasses.enabled = false;
        }
    }
}
