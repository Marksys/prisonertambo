using UnityEngine;
using System.Collections;

public class AtiraDroneGun : MonoBehaviour {

	public GameObject tiro;
	public Transform cano;
		
	public void Atirar()
	{
		//1.15f
		GameObject clone = (GameObject)Instantiate(tiro, new Vector3(transform.position.x, cano.position.y, transform.position.z), new Quaternion(0,0,0,0));
		//clone.transform.Translate(Vector3.forward*2);
		clone.GetComponent<Rigidbody>().AddForce(transform.forward * 300f);
		clone.GetComponent<Rigidbody>().useGravity = false;
	}
}
