using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Objeto
{
	public Objeto(string name, string id)
	{
		Name = name;
		_id = id + "_" + name;
		listaAnimations = new List<string>();
	}
	
	public virtual string Call()
	{
		return Name + "\\ ";
	}
	
	public virtual string Open(AudioClip audio, Vector3 position)
	{
		if(CantOpenClose)
		{
			TocaAudioErro(position);
			return "ERROR:.Object Cannot Open\n>";
		}
		else if (IsOpen)
		{
			TocaAudioErro(position);
			return Name + " Is Already Opened\n>";
		}
		else
		{
			if (HasPassword)
			{
				TocaAudioErro(position);
				return "ERROR:.Password Required\n>";
			}
			else
			{
				IsOpen = true;
				_animation.Play(listaAnimations[0]);
				AudioSource.PlayClipAtPoint(audio, position, 0.6f);
				return  Name + " Is Open\n>";
			}
		}
	}
	
	public virtual string Close(AudioClip audio, Vector3 position)
	{
		if(CantOpenClose)
		{
			TocaAudioErro(position);
			return "ERROR:.Object Cannot Close\n>";
		}
		else if(!IsOpen)
		{
			TocaAudioErro(position);
			return Name + " Is Already Closed\n>";
		}
		else{
			_animation.Play(listaAnimations[1]);
			AudioSource.PlayClipAtPoint(audio, position, 0.6f);
			IsOpen = false;
			return Name + " Has Been Closed\n>";
		}
	}
	
	public virtual string Fire(AudioClip audio, Vector3 position)
	{
		if(CantFire)
		{
			TocaAudioErro(position);
			return "ERROR:.Object Cannot Fire\n>";
		}
		else if (HasPassword)
		{
			TocaAudioErro(position);
			return "ERROR:.Password Required\n>";
		}
		else
		{
			obj3d.GetComponent<AtiraDroneGun>().Atirar();
			AudioSource.PlayClipAtPoint(audio, position, 0.6f);
			return Name + " has Been Fired\n>";
		}
	}
	
	public virtual string Activate(AudioClip audio, Vector3 position)
	{
		if(CantActivate)
		{
			TocaAudioErro(position);
			return "ERROR:.Object Cannot Activate\n>";
		}
		else
		{
			AudioSource.PlayClipAtPoint(audio, position, 0.6f);			
			GameObject objetoTransportar = obj3d.GetComponent<TeleportPad>().objectAbove;			
			if(objetoTransportar != null)
			{
				Vector3 padDestiny = DestinyTeleporter.position;
				padDestiny.y -= 0.5f; //colocar um pouco para baixo
				objetoTransportar.transform.position = padDestiny;
				obj3d.GetComponent<TeleportPad>().objectAbove = null; //objeto soh pode ir uma vez
			}
			return Name + " has Been Activated\n>";
		}
	}
	
	private void TocaAudioErro(Vector3 position)
	{
		if(AudioErro != null)
			AudioSource.PlayClipAtPoint(AudioErro, position, 0.6f);
	}

	public GameObject obj3d {get;set;}	
	public Animation _animation {get;set;}
	public List<string> listaAnimations {get;set;}
	public bool HasPassword { get; set; }
	public string Name { get; set; }
	private string _id;
	public string Id { get{ return _id;} }
	public bool IsOpen { get; set; }
	public bool CantOpenClose {get;set;}
	public bool CantFire {get;set;}
	public bool CantActivate {get;set;}
	public Transform DestinyTeleporter {get; set; }
	public AudioClip AudioErro {get;set;}
}
