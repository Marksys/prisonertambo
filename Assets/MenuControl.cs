using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Text;

public class MenuControl : MonoBehaviour {

	public List<Button> listaBtn;
	public List<string> listaCmds;	
	public Text _Output;
	public Image _imageScroll;
	public GameObject TerminalGui;
	public MoveChar scriptMove;
	public string IdTerminal;
	public Camera cameraTerminal;
	public GameObject _cameraOnline;
	public GameObject _cameraOffline;
	public GameObject notePad;
	public Text _mensNotePad;
	public Button _fecharNotepad;
	
	Objeto obj = null;
	
	public AudioClip door;
	public AudioClip shot;
	public AudioClip gate;
	public AudioClip teleporter;
	public AudioClip crack;
	public AudioClip erro;
	
	AudioClip audioCmd;
	
	
	public void ReiniciaTerminal()
	{
		_cameraOnline.SetActive(false);
		_cameraOffline.SetActive(true);
		
		StringBuilder str = new StringBuilder();
		str.Append ("Computer Associates Intro\n");
		str.Append("\n");
		str.Append("Hardware Security\n");
		str.Append("Version 22.7.99\n");
		str.Append("\n");
		str.Append(">Login: \n");
		str.Append(">Admin \n");
		str.Append(">Password:\n");
		str.Append(">************\n");
		str.Append(">Login succeeded\n");		
		str.Append("\n\n\n>");
		
		_Output.text = str.ToString ();
		
		for (int i = 0; i < listaCmds.Count; i++) {		
			listaBtn[i].enabled = true;
			string text = listaCmds[i].ToString ();
			listaBtn[i].GetComponentInChildren<Text>().text = text;
			listaBtn[i].onClick.RemoveAllListeners ();
			listaBtn[i].onClick.AddListener(() => { Output(text); });
			
			listaBtn[i].GetComponentInChildren<Text>().color = EstadoJogo.corFonteTexto;
		}
		
		for (int i = 0; i < listaBtn.Count; i++) {
			if(i >= listaCmds.Count)
			{
				listaBtn[i].enabled = false;
				listaBtn[i].GetComponentInChildren<CanvasRenderer>().SetAlpha(0);
				listaBtn[i].GetComponentInChildren<Text>().color = Color.clear;
			}
		}
		
		obj = null;		
				
		listaBtn[0].Select ();
	}
	
	void Start () {
		
		
	}
	
	void Update () {
		
	}
	
	public void Output(string texto)
	{
		_Output.text += texto + "\n>";		
		
		if (texto.ToUpper().Contains("READ"))
		{
            EstadoJogo.PodeMostrarExit = false;
			if (texto.ToUpper().Contains("HOW TO HACK"))
			{
				_mensNotePad.text = EstadoJogo.F1howHack.Read();
			}
			else if(texto.ToUpper().Contains("FRIEND NOTE"))
			{
				//Fase1
				if(IdTerminal == "F1Terminal3")
					_mensNotePad.text = EstadoJogo.F1friendNote1.Read();
				else if(IdTerminal == "F1Terminal2")
					_mensNotePad.text = EstadoJogo.F1friendNote2.Read();
				else if(IdTerminal == "F1Terminal4b")
					_mensNotePad.text = EstadoJogo.F1friendNote3.Read();
				//fase2
				else if(IdTerminal == "F2Terminal1")
					_mensNotePad.text = EstadoJogo.F1friendNote1.Read();
				else if(IdTerminal == "F2Terminal2")
					_mensNotePad.text = EstadoJogo.F1friendNote2.Read();
				else if(IdTerminal == "F2Terminal3")
					_mensNotePad.text = EstadoJogo.F1friendNote3.Read();
			}
			else if(texto.ToUpper().Contains("LAURA NOTE"))
			{
				//fase3
				if(IdTerminal == "F3Terminal1")
					_mensNotePad.text = EstadoJogo.F1friendNote1.Read();
				else if(IdTerminal == "F3Terminal2")
					_mensNotePad.text = EstadoJogo.F1friendNote2.Read();
				else if(IdTerminal == "F3Terminal3")
					_mensNotePad.text = EstadoJogo.F1friendNote3.Read();				
			}
			
			notePad.SetActive(true);
			MudaInteractable(false);				
			_fecharNotepad.Select();
		}
		else if (texto.ToUpper().Contains("EXEC"))
		{
			if (texto.ToUpper().Contains("CRACKER"))
			{	
				EstadoJogo.hacker.Objeto = obj;
				_Output.text += EstadoJogo.hacker.BreakPassword();
				if(!obj.HasPassword) //se quebrou password, se tentar quebrar depois q ja quebrou deixa tocar...
					AudioSource.PlayClipAtPoint(crack, transform.position, 0.6f);
			}			
			if (texto.ToUpper().Contains("EXIT"))
			{
				scriptMove.PodeMover = true;
				scriptMove.AcabouSairMenu = true;
				TerminalGui.SetActive (false);
			}
			
			if (obj != null)
				_Output.text += obj.Call();
		}
		else if (texto.ToUpper().Contains("CALL")) //qndo criar um objeto, colocar aqui o tipo de objeto e ir para o EstadoJogo estatico criar o resto
		{
			if (texto.ToUpper().Contains("DOOR"))
			{
				audioCmd = door;
				obj = EstadoJogo.Busca(IdTerminal+"_Door");
				MudaCameraTerminal();
				
			}
			else if (texto.ToUpper().Contains("SUPER GUN"))
			{
				audioCmd = shot;
				obj = EstadoJogo.Busca(IdTerminal+"_Super Gun");
				MudaCameraTerminal();
				
			}
			else if (texto.ToUpper().Contains("DRONE GUN"))
			{
				audioCmd = shot;
				
				if(texto.ToUpper().Contains("DRONE GUN 1"))
					obj = EstadoJogo.Busca(IdTerminal+"_Drone Gun1");
				else if(texto.ToUpper().Contains("DRONE GUN 2"))
					obj = EstadoJogo.Busca(IdTerminal+"_Drone Gun2");
				else
					obj = EstadoJogo.Busca(IdTerminal+"_Drone Gun");
					
				MudaCameraTerminal();
			}
			else if (texto.ToUpper().Contains("GATE"))
			{
				audioCmd = gate;
				
				if(texto.ToUpper().Contains("GATE 1"))
					obj = EstadoJogo.Busca(IdTerminal+"_Gate1");
				else if(texto.ToUpper().Contains("GATE 2"))
					obj = EstadoJogo.Busca(IdTerminal+"_Gate2");
				else
				obj = EstadoJogo.Busca(IdTerminal+"_Gate");
				MudaCameraTerminal();
			}
			else if (texto.ToUpper().Contains("TELEPORTER"))
			{
				audioCmd = teleporter;
				
				//caso tenha mais de um teleporter por sala, tem de estar identificado, o else final, pega no caso de apenas um
				if(texto.ToUpper().Contains("TELEPORTER 1"))
				   	obj = EstadoJogo.Busca(IdTerminal+"_Teleporter1");
			    else if(texto.ToUpper().Contains("TELEPORTER 2"))
					obj = EstadoJogo.Busca(IdTerminal+"_Teleporter2");
				else if(texto.ToUpper().Contains("TELEPORTER 3"))
					obj = EstadoJogo.Busca(IdTerminal+"_Teleporter3");
				else
					obj = EstadoJogo.Busca(IdTerminal+"_Teleporter");
				
				MudaCameraTerminal();
			}
			
			if(obj != null)
				obj.AudioErro = erro;
				
			_Output.text += obj.Call();
		}
		
		else if (obj == null)
			_Output.text += "ERROR:.Call a object!\n>";
		
		else if (texto.ToUpper().Contains("CMD"))
		{
			if (texto.ToUpper().Contains("OPEN"))
			{
				_Output.text += obj.Open(audioCmd, transform.position);
			}
			else if (texto.ToUpper().Contains("CLOSE"))
			{
				_Output.text += obj.Close(audioCmd, transform.position);
			}
			else if (texto.ToUpper().Contains("FIRE"))
			{
				_Output.text += obj.Fire(audioCmd, transform.position);
			}
			else if (texto.ToUpper().Contains("ACTIVATE"))
			{	
				_Output.text += obj.Activate(audioCmd, transform.position);
                //teleport de saída, se tiver alguma plataforma tampando a visao da camera, colocar o Id aqui do origem aqui
                if (obj.Id == "F4Terminal3_Teleporter1")
                    MudaCameraTeleport(true);
                else
				    MudaCameraTeleport(false);
			}
			
			if(obj != null)
				_Output.text += obj.Call();
		}		
		
		Canvas.ForceUpdateCanvases();
		_imageScroll.GetComponent<ScrollRect>().verticalNormalizedPosition = 0f;
	}
	
	private void MudaCameraTerminal()
	{
		Vector3 posCamTerminal = obj.obj3d.transform.position;
		if(obj.Id.Contains("Drone Gun") || obj.Id.Contains("Super Gun"))
			posCamTerminal.y = 4.25f;
		else
			posCamTerminal.y = 3.5f;
		
		cameraTerminal.transform.rotation = obj.obj3d.transform.rotation;
		cameraTerminal.transform.position = posCamTerminal;
        if (obj.Id.Contains("Door"))
        {
            //porta aberta
            if (obj.IsOpen)
            {
                cameraTerminal.transform.Translate(-Vector3.forward * 4);
                cameraTerminal.transform.Translate(-Vector3.up * 4);
            }
            else
                cameraTerminal.transform.Translate(-Vector3.forward * 4);
        }
        else
            cameraTerminal.transform.Translate(-Vector3.forward * 3);
		
		cameraTerminal.transform.LookAt(obj.obj3d.transform);
		_cameraOnline.SetActive(true);
		_cameraOffline.SetActive(false);
	}
	
	private void MudaCameraTeleport(bool teleportBaixo)
	{
		if(obj.DestinyTeleporter != null && obj.Id.Contains("Teleporter"))
		{
			Vector3 posCamTerminal = obj.DestinyTeleporter.transform.position;
            if (teleportBaixo)
                posCamTerminal.y = 6f;
            else
			    posCamTerminal.y = 3f;
			
			cameraTerminal.transform.rotation = obj.DestinyTeleporter.transform.rotation;
			cameraTerminal.transform.position = posCamTerminal;		
			cameraTerminal.transform.Translate(-Vector3.forward*5);
			
			cameraTerminal.transform.LookAt(obj.DestinyTeleporter.transform);
			_cameraOnline.SetActive(true);
			_cameraOffline.SetActive(false);
		}
	}
	
	public void FechaNotepad()
	{
        EstadoJogo.PodeMostrarExit = true;
        notePad.SetActive(false);
		listaBtn[0].Select ();
		MudaInteractable(true);
	}
	
	public void ExitDemo()
	{
		Application.Quit();
	}
	
	public void MudaInteractable(bool status)
	{
		for (int i = 0; i < listaCmds.Count; i++) {		
			listaBtn[i].interactable = status;
		}
	}
}
