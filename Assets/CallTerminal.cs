using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CallTerminal : MonoBehaviour {
	
	public bool PlayerOlhando = false;	
	
	public List<string> listaCmds;	
	
	public GameObject GUI_Terminal;
	public MenuControl _menuScript;
	public MoveChar scriptMove;
	
	public string IdTerminal;
	
	public AudioClip plimTerminal;
	AudioSource audioS;
	
	public int NivelTerminal;
	
	void Start() 
	{
		audioS = GetComponent<AudioSource>();
	}
	
	void Update()
	{		
		if(PlayerOlhando)
		{			
			if ((Input.GetButton("Submit") || Input.GetButton("SubmitMouse")) && !GUI_Terminal.activeSelf && !scriptMove.AcabouSairMenu && scriptMove.PodeMover) 
			{
				scriptMove.PodeMover = false;
				GUI_Terminal.SetActive (true);
				MontaMenu();
				audioS.PlayOneShot(plimTerminal,0.5f);
			}		
		}
	}

	void MontaMenu()
	{
		if(_menuScript != null)
		{	
			_menuScript.listaCmds = listaCmds;
			_menuScript.IdTerminal = IdTerminal;
			_menuScript.scriptMove = scriptMove;
			_menuScript.ReiniciaTerminal();
		}
	}
}
