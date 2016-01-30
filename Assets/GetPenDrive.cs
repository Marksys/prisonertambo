using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetPenDrive : MonoBehaviour {
	
	public GameObject _holderMensagem;
	public bool PlayerOlhando = false;
	
	public AudioClip plim;

	// Update is called once per frame
	void Update () 
	{
		if(PlayerOlhando)
		{
			if (Input.GetButton("Submit") || Input.GetButton("SubmitMouse")) 
            {
				AudioSource.PlayClipAtPoint(plim, transform.position);
				EstadoJogo.HasPenDrive = true;							
				Destroy(gameObject);
				_holderMensagem.SetActive(false);				
			}
		}
	}
}
