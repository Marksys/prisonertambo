using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public GameObject DestroyedObject;
	private bool IsDestroyed = false;
	public bool VaiParaTras = false;
	
	void OnCollisionEnter(Collision collision)
	{	
		if(!IsDestroyed && (collision.gameObject.tag == "Push"))
		{
			if(collision.gameObject.transform.position.y > (transform.position.y+0.2f)) //verifica se a posicao eh acima do caixa
			{
				DestroyIt();
			}
		}
	}
	
	void OnTriggerEnter( Collider other ) {
		if(!IsDestroyed && (other.tag == "TiroSimples"))
		{
			DestroyIt();
		}
	}
	
	void DestroyIt(){
		
		GameObject brokenBox = (GameObject)Instantiate(DestroyedObject, transform.position, transform.rotation);
		if(VaiParaTras)
			brokenBox.transform.Translate(-Vector3.forward*2);
		
		MeshCollider[] listaFractureBox = brokenBox.GetComponentsInChildren<MeshCollider>();
		
		//vou desabilitar estes colliders, tao atrapalhando muito
		int i = 0;
		foreach (var item in listaFractureBox) 
		{
			if(i <= 15) //os 10 primeiros sao as quinas q atrapalham
			{
				item.enabled = false;
				item.GetComponent<MeshRenderer>().enabled = false;
			}
			else
				break;
								
			i++;
		}
			
		brokenBox.transform.parent = gameObject.transform.parent;		
		Destroy(gameObject);
		
		IsDestroyed = true;
	}
}