using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boards : MonoBehaviour
{

    public bool lLocked = false;
    public bool rLocked = false;
    public float lockedZ = -2.8f;
    public bool LockedBoth = false;
    public bool grabbed = false;
    public bool nailedIn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

        if (LockedBoth && grabbed == false && GetComponent<BoxCollider>().enabled == true)
        {
            nailed();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "lockleft")
        //{
        //    Debug.Log("LEFT");
        //    if (other.gameObject.GetComponent<HingeJoint>() == null)
        //    {

        //        HingeJoint left = other.gameObject.AddComponent<HingeJoint>();
        //        left.connectedBody = gameObject.GetComponent<Rigidbody>();
        //    }
        //}

        //if (other.gameObject.tag == "lockright")
        //{
        //    Debug.Log("RIGHT");
        //    HingeJoint right = other.gameObject.AddComponent<HingeJoint>();
        //    right.connectedBody = gameObject.GetComponent<Rigidbody>();
        //}

        if (other.CompareTag("lockleft"))
        {
            lLocked = true;
        }
        else if (other.CompareTag("lockright"))
        {
            rLocked = true;
        }

        if (lLocked && rLocked)
        {
            //nailed(other.gameObject);
            LockedBoth = true;

        }
    }
    private void nailed()
    {
        Vector3 pos = transform.position;
        pos.z = lockedZ;
        transform.position = pos;
        // gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        //FixedJoint locked = nail.AddComponent<FixedJoint>();
        // locked.connectedBody = gameObject.GetComponent<Rigidbody>();
        GetComponent<BoxCollider>().enabled = false;
        nailedIn = true; 
      
    }
}
