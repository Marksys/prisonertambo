using UnityEngine;
using System.Collections;

public class GrabAndDrop : MonoBehaviour {

    //Stuart Spence tutorial
    public GameObject grabbedObject;
    float grabbedObjectSize;

    GameObject GetMouseHoverObject(float range)
    {
        Vector3 position = transform.position + transform.up;
        RaycastHit raycastHit;
        Vector3 target = position + transform.forward * range;

        Debug.DrawLine(position, target, Color.blue);

        if (Physics.Linecast(position, target, out raycastHit))
            return raycastHit.collider.gameObject;

        return null;

    }

    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null || !CanGrab(grabObject))
            return;

        grabbedObject = grabObject;

        grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude;
    }

    bool CanGrab(GameObject candidate)
    {
        if (candidate.GetComponent<Rigidbody>() != null && candidate.tag == "Push")
            return true;
        else
            return false;
    }

    void DropObject()
    {
        if (grabbedObject == null)
            return;

        if (grabbedObject.GetComponent<Rigidbody>() != null)
            grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        grabbedObject = null;
    }
   
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (grabbedObject == null)
                TryGrabObject(GetMouseHoverObject(0.85f));
            else
                DropObject();

            print(grabbedObject);
        }

        if (grabbedObject != null)
        {
            if (GetComponent<FixedJoint>().connectedBody == null)
            {
                grabbedObject.transform.LookAt(gameObject.transform);

                var dir = grabbedObject.transform.forward; // get the hit direction
                //dir.y = 0; // consider only the horizontal direction
                gameObject.GetComponentInParent<CharacterController>().SimpleMove(10f * dir.normalized);
                //Vector3 newPosition = gameObject.transform.position + transform.forward * grabbedObjectSize / 2 + transform.up * 0.5f;
                //grabbedObject.transform.position = newPosition;
                //grabbedObject.GetComponent<Rigidbody>().MovePosition(newPosition);
                GetComponent<FixedJoint>().connectedBody = grabbedObject.GetComponent<Rigidbody>();
            }
        }
        else
            GetComponent<FixedJoint>().connectedBody = null;

    }
}

