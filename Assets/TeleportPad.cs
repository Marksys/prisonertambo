using UnityEngine;
using System.Collections;

public class TeleportPad : MonoBehaviour {

	public GameObject objectAbove;
	public void OnTriggerStay(Collider other)
	{
		if(other.tag == "Push")
			objectAbove = other.gameObject;
	}
	
	public void OnTriggerExit(Collider other)
	{
		if(other.tag == "Push")
			objectAbove = null;
	}
}
