using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {

	float startTime = 0f;
	public int TipoTiro;	
	
	void Update()
	{
		if(startTime == 0f)
			startTime = Time.time;
			
		if((Time.time - startTime)> 10f) //depois de 5 segundos, destruir, caso esteja vivo.
			Destroy(gameObject);
	}
	
	public void OnTriggerEnter(Collider other)
	{	
		if(other.tag != "Player" && other.tag != "Item" && other.tag != "MudaCamera")
			Destroy(gameObject);
	}
}
