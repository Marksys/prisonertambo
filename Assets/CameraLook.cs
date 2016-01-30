using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {

	public Transform target;
	public Transform startPosition;
	
	void Start()
	{
		transform.position = startPosition.position;
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
