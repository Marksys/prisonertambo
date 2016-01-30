using UnityEngine;
using System.Collections;

public class MudaCamera : MonoBehaviour {

	
	public Camera _camera;
	public Transform position;
	
	public void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			_camera.transform.position = position.position;
			_camera.transform.rotation = position.rotation;
		}
	}
	
	public void MudaCameraScript()
	{
		_camera.transform.position = position.position;
		_camera.transform.rotation = position.rotation;
	}
}
