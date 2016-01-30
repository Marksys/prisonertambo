using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutScene2 : MonoBehaviour {

	public GameObject Adam;
	public GameObject Laura;
	private CharacterController controllerLaura;
	private Animator animatorLaura;
	
	private bool StopWalk = false;	
	public bool StartCutScene = false;
	private bool StartTalk = false;
	
	public Transform cameraCutScene;
	public Transform lastCameraTrans;
	
	public Text _nameChar;
	public Text _mensagem;
	public GameObject MensagemUI;
	
	public Image CanvMens;
	public Image CanvNome;
	public Color CorLaura;
	public Color CorAdam;
	public Color CorDefault;
	
	private int indiceMens = 0;
	private float nextFire;
	
	// Use this for initialization
	void Start () {
		controllerLaura = Laura.GetComponent<CharacterController>();
		animatorLaura = Laura.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	float startTimeMove;
	void FixedUpdate ()
	{
		if(StartCutScene && !StartTalk)
		{
			Adam.GetComponent<MoveChar>().enabled = false;
			float distance = Vector3.Distance (Laura.transform.position, Adam.transform.position);
			
			if(distance < 0.8f)
				StopWalk = true;
			
			Adam.transform.LookAt(Laura.transform);
			Laura.transform.LookAt(Adam.transform);
			
			if(!StopWalk)
			{
				if(startTimeMove == 0f)
					startTimeMove = Time.time;
					
				Camera.allCameras[0].GetComponent<CameraLook>().enabled = false;
				Camera.allCameras[0].transform.position = cameraCutScene.position;
				Camera.allCameras[0].transform.rotation = cameraCutScene.rotation;
				
				Vector3 forward = Laura.transform.TransformDirection(Vector3.forward); 
				float curSpeed = 1f;
				
				animatorLaura.SetFloat("Speed", curSpeed);
				
				if((Time.time - startTimeMove) > 0.8f) //esperar um momentinho para mover, se for controlar a Laura, mexer no controller animation depois...
					controllerLaura.SimpleMove(forward * curSpeed);				
			}
			else
			{
				animatorLaura.SetFloat("Speed", 0f);
                animatorLaura.SetBool("IsRunning", false);        
                animatorLaura.SetFloat("Axis", 0f);
                animatorLaura.SetBool("IsStopped", true);
                StartTalk = true;				
			}
		}
		
		if(StartTalk)
		{
			MensagemUI.SetActive(true);
			
			switch (indiceMens) 
			{
				case 0:
				{
					MontaDialogo("Laura", Textos.Fase2Chat1b);
					break;
				}
				case 1:
				{
					MontaDialogo("Adam", Textos.Fase2Chat2b);
					break;
				}
				case 2:
				{
					MontaDialogo("Laura", Textos.Fase2Chat3b);
					break;
				}
				case 3:
				{
					MontaDialogo("Adam", Textos.Fase2Chat4b);
					break;
				}
				case 4:
				{
					MontaDialogo("Laura", Textos.Fase2Chat5b);					
					break;
				}
				case 5:
				{
					MontaDialogo("Laura", Textos.Fase2Chat6b);
					break;
				}
				case 6:
				{
					MontaDialogo("Laura", Textos.Fase2Chat7b);
					break;
				}
				case 7:
				{
					MontaDialogo("Adam", Textos.Fase2Chat8b);					
					break;
				}
				case 8:
				{
					_nameChar.text = "";
					_mensagem.text = "";
					CanvMens.color = CorDefault;
					CanvNome.color = Color.clear;
					Camera.allCameras[0].GetComponent<CameraLook>().enabled = true;
					Camera.allCameras[0].transform.position = lastCameraTrans.position;
					Camera.allCameras[0].transform.rotation = lastCameraTrans.rotation;
					Adam.GetComponent<MoveChar>().enabled = true;
					StartTalk = false;
					MensagemUI.SetActive(false);
					Destroy(this);
					break;
				}
				default:
					break;
			}
			
			if(Input.GetButton("Submit")  && Time.time > nextFire)
			{
				nextFire = Time.time + 0.5f;
				indiceMens++;
			}
		}
	}
	
	private void MontaDialogo(string Personagem, string texto)
	{		
		if(Personagem == "Laura")
		{
			CanvMens.color = CorLaura;
			CanvNome.color = CorLaura;
			_nameChar.text = "Laura";
		}
		else if(Personagem == "Adam")
		{
			CanvMens.color = CorAdam;
			CanvNome.color = CorAdam;
			_nameChar.text = "Adam";			
		}
		
		_mensagem.text = texto;
	}
}
