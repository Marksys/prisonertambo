using UnityEngine;
using System.Collections;

public class DropGrab : MonoBehaviour
{
    public GrabAndDrop grabDrop;

    void OnCollisionEnter()
    {
        if (grabDrop.grabbedObject != null)
        {
            grabDrop.grabbedObject.GetComponent<Rigidbody>().Sleep();
            grabDrop.grabbedObject = null;
        }
        
    }    
}
