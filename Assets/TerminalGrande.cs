using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TerminalGrande : MonoBehaviour {

	public GameObject CrackerUI;
	public GameObject MensagemUI;
	public Text _textoMensagem;
	public AudioClip plimTerminal;	
	public MoveChar moveChar;
	public bool AcabouSairMenu = false;
    public Camera cameraHacking;
	
	// Use this for initialization
	void Start () {
	
	}
	
	float timerMenu = 0f;
	void Update () 
	{
		//gambi para nao ficar em looping quando sair do menu
		if(AcabouSairMenu && timerMenu == 0f)
			timerMenu = Time.time;
		
		if(timerMenu > 0f && (Time.time - timerMenu) > 0.5f)
		{
			AcabouSairMenu = false;
			timerMenu = 0f;
		}
		//fim da gambi
	}
	
	public void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player" && !CrackerUI.activeSelf && !AcabouSairMenu)
		{
			MensagemUI.SetActive(true);
			_textoMensagem.text = Textos.UseControlTerminal;
			
			if (Input.GetButton("Submit"))
			{
				MensagemUI.SetActive(false);
				CrackerUI.SetActive(true);
				moveChar.PodeMover = false;
                cameraHacking.enabled = true;

                AudioSource.PlayClipAtPoint(plimTerminal, transform.position, 0.7f);
			}
		}
	}
	
	public void OnTriggerExit(Collider other)
	{
		MensagemUI.SetActive(false);
        _textoMensagem.text = "";
	}
}
