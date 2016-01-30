using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class EstadoJogo  {

	public static List<Objeto> listaObjeto;
	public static bool HasPenDrive = true;
	public static bool HasPenDrive2 = false;
	public static bool HasTutorial = false;
    public static bool PodeMostrarExit = true;

    //Cores dos botoes dinamicos;
    public static Color corFonteTexto;
	
	public static Software hacker = new Software(); //Cracker	
	
	//todos os objetos 3ds criados, coloca-los aqui e replicar no EstadoJogoGO
	//Fase1
	public static GameObject F1door;
	public static GameObject F1door2;	
	public static GameObject F1gate2;	
	public static GameObject F1droneGun2;
	public static GameObject F1droneGun3;
	public static GameObject F1door3;	
	public static GameObject F1door4;
	public static GameObject F1gate4;
	public static GameObject F1droneGun4a;
	public static GameObject F1droneGun4b;
	public static Software F1friendNote1 = new Software(); //Message
	public static Software F1friendNote2 = new Software(); //Message
	public static Software F1friendNote3 = new Software(); //Message
	public static Software F1howHack = new Software();  //Message
	
	//Fase2
	public static GameObject F2door1;
	public static GameObject F2teleport1a;
	public static GameObject F2teleport1b;
	public static GameObject F2door2;
	public static GameObject F2teleport2a1;
	public static GameObject F2teleport2a2;
	public static GameObject F2teleport2b1;
	public static GameObject F2teleport2b2;
	public static GameObject F2door3;
	public static GameObject F2teleport3a;
	public static GameObject F2teleport3b;
	public static GameObject F2droneGun3;
	public static GameObject F2door4;
	
	//Fase3
	public static GameObject F3door1;
	public static GameObject F3door2a;
	public static GameObject F3door2b;
	public static GameObject F3teleport2a1;
	public static GameObject F3teleport2b1;
	public static GameObject F3teleport2c1;
	public static GameObject F3teleport2a2;
	public static GameObject F3teleport2b2;
	public static GameObject F3teleport2c2;
	public static GameObject F3droneGun2a;
	public static GameObject F3gate2a;
	public static GameObject F3droneGun2b;
	public static GameObject F3gate2b;
	public static GameObject F3door3;
	
	//Fase4
	public static GameObject F4door1;
	public static GameObject F4teleport1a1;
	public static GameObject F4teleport1b1;
	public static GameObject F4teleport1a2;
	public static GameObject F4teleport1b2;
	public static GameObject F4door2a;
	public static GameObject F4door2b;
	public static GameObject F4superGun2;
	public static GameObject F4teleport3a1;
	public static GameObject F4teleport3b1;
	public static GameObject F4teleport3a2;
	public static GameObject F4teleport3b2;
	public static GameObject F4teleport4a1;
	public static GameObject F4teleport4b1;
	public static GameObject F4teleport4c1;
	public static GameObject F4teleport4a2;
	public static GameObject F4teleport4b2;	
	public static GameObject F4teleport4c2;
	public static GameObject F4gate4a;
	public static GameObject F4droneGun4a;
	public static GameObject F4droneGun4b;	
	
	public static void StartF1()
	{
		EstadoJogo.HasPenDrive = false;
		listaObjeto = new List<Objeto>();
		
		//criar os Objetos, Id e Nome muito importante para amarrar com o MenuControl
		Objeto F1doorObj = new Objeto("Door","F1Terminal1");
		F1doorObj.Name = "Door";		
		F1doorObj.obj3d = F1door;
		F1doorObj._animation = F1door.GetComponent<Animation>();
		F1doorObj.listaAnimations.Add("DoorOpen");
		F1doorObj.listaAnimations.Add("DoorClose");
		F1doorObj.HasPassword = true;
		F1doorObj.CantFire = true;
		listaObjeto.Add(F1doorObj);		
		
		Objeto F1doorObj2  = new Objeto("Door","F1Terminal2");
		F1doorObj2.Name = "Door";
		F1doorObj2.obj3d = F1door2;
		F1doorObj2._animation = F1door2.GetComponent<Animation>();
		F1doorObj2.listaAnimations.Add("DoorOpen");
		F1doorObj2.listaAnimations.Add("DoorClose");
		F1doorObj2.HasPassword = true;
		F1doorObj2.CantFire = true;
		listaObjeto.Add(F1doorObj2);
		
		Objeto F1gateObj2  = new Objeto("Gate","F1Terminal2");
		F1gateObj2.Name = "Gate";
		F1gateObj2.obj3d = F1gate2;
		F1gateObj2._animation = F1gate2.GetComponent<Animation>();
		F1gateObj2.listaAnimations.Add("OpenGate");
		F1gateObj2.listaAnimations.Add("CloseGate");
		F1gateObj2.HasPassword = false;
		F1gateObj2.CantFire = true;
		listaObjeto.Add(F1gateObj2);
		
		Objeto F1droneGunObj2 = new Objeto("Drone Gun","F1Terminal2");
		F1droneGunObj2.Name = "Drone Gun";
		F1droneGunObj2.obj3d = F1droneGun2;
		F1droneGunObj2.CantOpenClose = true;
		listaObjeto.Add(F1droneGunObj2);	
		
		Objeto F1doorObj3  = new Objeto("Door","F1Terminal3");
		F1doorObj3.Name = "Door";
		F1doorObj3.obj3d = F1door3;
		F1doorObj3._animation = F1door3.GetComponent<Animation>();
		F1doorObj3.listaAnimations.Add("DoorOpen");
		F1doorObj3.listaAnimations.Add("DoorClose");
		F1doorObj3.CantFire = true;
		F1doorObj3.HasPassword = true;
		listaObjeto.Add(F1doorObj3);
		
		Objeto F1droneGunObj3 = new Objeto("Drone Gun","F1Terminal3");
		F1droneGunObj3.Name = "Drone Gun";
		F1droneGunObj3.obj3d = F1droneGun3;
		F1droneGunObj3.CantOpenClose = true;
		listaObjeto.Add(F1droneGunObj3);	
		
		Objeto F1doorObj4  = new Objeto("Door","F1Terminal4b");
		F1doorObj4.Name = "Door";
		F1doorObj4.obj3d = F1door4;
		F1doorObj4._animation = F1door4.GetComponent<Animation>();
		F1doorObj4.listaAnimations.Add("DoorOpen");
		F1doorObj4.listaAnimations.Add("DoorClose");
		F1doorObj4.CantFire = true;
		F1doorObj4.HasPassword = true;
		listaObjeto.Add(F1doorObj4);
		
		Objeto F1droneGunObj4a = new Objeto("Drone Gun","F1Terminal4");
		F1droneGunObj4a.Name = "Drone Gun";
		F1droneGunObj4a.obj3d = F1droneGun4a;
		F1droneGunObj4a.CantOpenClose = true;
		listaObjeto.Add(F1droneGunObj4a);
		
		Objeto F1droneGunObj4b = new Objeto("Drone Gun2","F1Terminal4b");
		F1droneGunObj4b.Name = "Drone Gun";
		F1droneGunObj4b.obj3d = F1droneGun4b;
		F1droneGunObj4b.CantOpenClose = true;
		listaObjeto.Add(F1droneGunObj4b);	
		
		Objeto F1gateObj4  = new Objeto("Gate","F1Terminal4");
		F1gateObj4.Name = "Gate";
		F1gateObj4.obj3d = F1gate4;
		F1gateObj4._animation = F1gate4.GetComponent<Animation>();
		F1gateObj4.listaAnimations.Add("OpenGate");
		F1gateObj4.listaAnimations.Add("CloseGate");
		F1gateObj4.HasPassword = false;
		F1gateObj4.CantFire = true;
		listaObjeto.Add(F1gateObj4);
        
        F1howHack.Message = Textos.Fase1HowToHack;
		F1friendNote1.Message = Textos.Fase1Friend1;
        F1friendNote2.Message = Textos.Fase1Friend2;
        string retFriendNote3 = "\n\n\n";
		retFriendNote3 += "  =)\n";		
		F1friendNote3.Message = retFriendNote3;
	}
	
	public static void StartF2()
	{
		EstadoJogo.HasPenDrive = true;
		EstadoJogo.HasPenDrive2 = false;
		listaObjeto = new List<Objeto>();
		
		//criar os Objetos, Id e Nome muito importante para amarrar com o MenuControl
		Objeto F2doorObj = new Objeto("Door","F2Terminal1");
		F2doorObj.Name = "Door";		
		F2doorObj.obj3d = F2door1;
		F2doorObj._animation = F2door1.GetComponent<Animation>();
		F2doorObj.listaAnimations.Add("DoorOpen");
		F2doorObj.listaAnimations.Add("DoorClose");
		F2doorObj.HasPassword = true;
		F2doorObj.CantFire = true;
		F2doorObj.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F2doorObj);
		
		Objeto F2pad1Obj = new Objeto("Teleporter","F2Terminal1");
		F2pad1Obj.Name = "Teleporter";
		F2pad1Obj.obj3d = F2teleport1a;
		F2pad1Obj.DestinyTeleporter = F2teleport1b.transform;
		F2pad1Obj.CantFire = true;
		F2pad1Obj.CantOpenClose = true;
		listaObjeto.Add(F2pad1Obj);
		
		Objeto F2doorObj2 = new Objeto("Door","F2Terminal2");
		F2doorObj2.Name = "Door";		
		F2doorObj2.obj3d = F2door2;
		F2doorObj2._animation = F2door2.GetComponent<Animation>();
		F2doorObj2.listaAnimations.Add("DoorOpen");
		F2doorObj2.listaAnimations.Add("DoorClose");
		F2doorObj2.HasPassword = true;
		F2doorObj2.CantFire = true;
		F2doorObj2.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F2doorObj2);
		
		Objeto F2pad2aObj = new Objeto("Teleporter1","F2Terminal2");
		F2pad2aObj.Name = "Teleporter";
		F2pad2aObj.obj3d = F2teleport2a1;
		F2pad2aObj.DestinyTeleporter = F2teleport2a2.transform;
		F2pad2aObj.CantFire = true;
		F2pad2aObj.CantOpenClose = true;
		listaObjeto.Add(F2pad2aObj);
		
		Objeto F2pad2bObj = new Objeto("Teleporter2","F2Terminal2");
		F2pad2bObj.Name = "Teleporter";
		F2pad2bObj.obj3d = F2teleport2b1;
		F2pad2bObj.DestinyTeleporter = F2teleport2b2.transform;
		F2pad2bObj.CantFire = true;
		F2pad2bObj.CantOpenClose = true;
		listaObjeto.Add(F2pad2bObj);
		
		Objeto F2doorObj3 = new Objeto("Door","F2Terminal3");
		F2doorObj3.Name = "Door";		
		F2doorObj3.obj3d = F2door3;
		F2doorObj3._animation = F2door3.GetComponent<Animation>();
		F2doorObj3.listaAnimations.Add("DoorOpen");
		F2doorObj3.listaAnimations.Add("DoorClose");
		F2doorObj3.HasPassword = true;
		F2doorObj3.CantFire = true;
		F2doorObj3.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F2doorObj3);
		
		Objeto F2pad3Obj = new Objeto("Teleporter","F2Terminal3");
		F2pad3Obj.Name = "Teleporter";
		F2pad3Obj.obj3d = F2teleport3a;
		F2pad3Obj.DestinyTeleporter = F2teleport3b.transform;
		F2pad3Obj.CantFire = true;
		F2pad3Obj.CantOpenClose = true;
		listaObjeto.Add(F2pad3Obj);
		
		Objeto F2droneGunObj3 = new Objeto("Drone Gun","F2Terminal3");
		F2droneGunObj3.Name = "Drone Gun";
		F2droneGunObj3.obj3d = F2droneGun3;
		F2droneGunObj3.CantOpenClose = true;
		F2droneGunObj3.CantActivate = true;
		listaObjeto.Add(F2droneGunObj3);	
		
		Objeto F2door4Obj = new Objeto("Door","F2Terminal4");
		F2door4Obj.Name = "Door";		
		F2door4Obj.obj3d = F2door4;
		F2door4Obj._animation = F2door4.GetComponent<Animation>();
		F2door4Obj.listaAnimations.Add("DoorOpen");
		F2door4Obj.listaAnimations.Add("DoorClose");
		F2door4Obj.HasPassword = true;
		F2door4Obj.CantFire = true;
		F2door4Obj.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F2door4Obj);
		
		//mensagenzinhas bestas
		F1friendNote1.Message = Textos.Fase2Friend1;
		F1friendNote2.Message = Textos.Fase2Friend2;
        F1friendNote3.Message = Textos.Fase2Friend3;
	}
	
	public static void StartF3()
	{
		EstadoJogo.HasPenDrive = true;
		EstadoJogo.HasPenDrive2 = false;
		listaObjeto = new List<Objeto>();
		
		//criar os Objetos, Id e Nome muito importante para amarrar com o MenuControl
		Objeto F3doorObj1 = new Objeto("Door","F3Terminal1");
		F3doorObj1.Name = "Door";		
		F3doorObj1.obj3d = F3door1;
		F3doorObj1._animation = F3door1.GetComponent<Animation>();
		F3doorObj1.listaAnimations.Add("DoorOpen");
		F3doorObj1.listaAnimations.Add("DoorClose");
		F3doorObj1.HasPassword = true;
		F3doorObj1.CantFire = true;
		F3doorObj1.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F3doorObj1);
		
		Objeto F3doorObj2a = new Objeto("Door","F3Terminal2");
		F3doorObj2a.Name = "Door";		
		F3doorObj2a.obj3d = F3door2a;
		F3doorObj2a._animation = F3door2a.GetComponent<Animation>();
		F3doorObj2a.listaAnimations.Add("DoorOpen");
		F3doorObj2a.listaAnimations.Add("DoorClose");
		F3doorObj2a.HasPassword = true;
		F3doorObj2a.CantFire = true;
		F3doorObj2a.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F3doorObj2a);
		
		Objeto F3doorObj2b = new Objeto("Door","F3Terminal2b"); //colocar o Id correto no terminal 2 b
		F3doorObj2b.Name = "Door";		
		F3doorObj2b.obj3d = F3door2b;
		F3doorObj2b._animation = F3door2b.GetComponent<Animation>();
		F3doorObj2b.listaAnimations.Add("DoorOpen");
		F3doorObj2b.listaAnimations.Add("DoorClose");
		F3doorObj2b.HasPassword = true;
		F3doorObj2b.CantFire = true;
		F3doorObj2b.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F3doorObj2b);
		
		Objeto F3padAObj2 = new Objeto("Teleporter1","F3Terminal2");
		F3padAObj2.Name = "Teleporter";
		F3padAObj2.obj3d = F3teleport2a1;
		F3padAObj2.DestinyTeleporter = F3teleport2a2.transform;
		F3padAObj2.CantFire = true;
		F3padAObj2.CantOpenClose = true;
		listaObjeto.Add(F3padAObj2);
		
		Objeto F3padBObj2 = new Objeto("Teleporter2","F3Terminal2");
		F3padBObj2.Name = "Teleporter";
		F3padBObj2.obj3d = F3teleport2b1;
		F3padBObj2.DestinyTeleporter = F3teleport2b2.transform;
		F3padBObj2.CantFire = true;
		F3padBObj2.CantOpenClose = true;
		listaObjeto.Add(F3padBObj2);
		
		Objeto F3padCObj2 = new Objeto("Teleporter3","F3Terminal2");
		F3padCObj2.Name = "Teleporter";
		F3padCObj2.obj3d = F3teleport2c1;
		F3padCObj2.DestinyTeleporter = F3teleport2c2.transform;
		F3padCObj2.CantFire = true;
		F3padCObj2.CantOpenClose = true;
		listaObjeto.Add(F3padCObj2);
		
		Objeto F3droneGunObj2a = new Objeto("Drone Gun1","F3Terminal2");
		F3droneGunObj2a.Name = "Drone Gun1";
		F3droneGunObj2a.obj3d = F3droneGun2a;
		F3droneGunObj2a.CantOpenClose = true;
		F3droneGunObj2a.CantActivate = true;
		listaObjeto.Add(F3droneGunObj2a);
		
		Objeto F3gateObj2a  = new Objeto("Gate1","F3Terminal2");
		F3gateObj2a.Name = "Gate";
		F3gateObj2a.obj3d = F3gate2a;
		F3gateObj2a._animation = F3gate2a.GetComponent<Animation>();
		F3gateObj2a.listaAnimations.Add("OpenGate");
		F3gateObj2a.listaAnimations.Add("CloseGate");
		F3gateObj2a.HasPassword = false;
		F3gateObj2a.CantFire = true;
		F3gateObj2a.CantActivate = true;
		listaObjeto.Add(F3gateObj2a);
		
		Objeto F3droneGunObj2b = new Objeto("Drone Gun2","F3Terminal2");
		F3droneGunObj2b.Name = "Drone Gun";
		F3droneGunObj2b.obj3d = F3droneGun2b;
		F3droneGunObj2b.CantOpenClose = true;
		F3droneGunObj2b.CantActivate = true;
		listaObjeto.Add(F3droneGunObj2b);
		
		Objeto F3gateObj2b  = new Objeto("Gate2","F3Terminal2");
		F3gateObj2b.Name = "Gate";
		F3gateObj2b.obj3d = F3gate2b;
		F3gateObj2b._animation = F3gate2b.GetComponent<Animation>();
		F3gateObj2b.listaAnimations.Add("OpenGate");
		F3gateObj2b.listaAnimations.Add("CloseGate");
		F3gateObj2b.HasPassword = false;
		F3gateObj2b.CantFire = true;
		F3gateObj2b.CantActivate = true;
		listaObjeto.Add(F3gateObj2b);
		
		Objeto F3doorObj3 = new Objeto("Door","F3Terminal3");
		F3doorObj3.Name = "Door";		
		F3doorObj3.obj3d = F3door3;
		F3doorObj3._animation = F3door3.GetComponent<Animation>();
		F3doorObj3.listaAnimations.Add("DoorOpen");
		F3doorObj3.listaAnimations.Add("DoorClose");
		F3doorObj3.HasPassword = true;
		F3doorObj3.CantFire = true;
		F3doorObj3.CantActivate = true; //Isso so existe a partir da fase 2, se for colocar activate na fase1 mudar la tb tudo
		listaObjeto.Add(F3doorObj3);
		
		//mensagenzinhas bestas
		
		F1friendNote1.Message = Textos.Fase3Friend1;	
		F1friendNote2.Message = Textos.Fase3Friend2;
        F1friendNote3.Message = Textos.Fase3Friend3;
	}
	
	public static void StartF4()
	{
		EstadoJogo.HasPenDrive = true;
		EstadoJogo.HasPenDrive2 = false;
		listaObjeto = new List<Objeto>();
		
		//criar os Objetos, Id e Nome muito importante para amarrar com o MenuControl
		Objeto F4doorObj1 = new Objeto("Door","F4Terminal1");
		F4doorObj1.Name = "Door";		
		F4doorObj1.obj3d = F4door1;
		F4doorObj1._animation = F4door1.GetComponent<Animation>();
		F4doorObj1.listaAnimations.Add("DoorOpen");
		F4doorObj1.listaAnimations.Add("DoorClose");
		F4doorObj1.HasPassword = true;
		F4doorObj1.CantFire = true;
		F4doorObj1.CantActivate = true;
		listaObjeto.Add(F4doorObj1);
		
		Objeto F4padAObj1 = new Objeto("Teleporter1","F4Terminal1");
		F4padAObj1.Name = "Teleporter";
		F4padAObj1.obj3d = F4teleport1a1;
		F4padAObj1.DestinyTeleporter = F4teleport1a2.transform;
		F4padAObj1.CantFire = true;
		F4padAObj1.CantOpenClose = true;
		listaObjeto.Add(F4padAObj1);
		
		Objeto F4padBObj1 = new Objeto("Teleporter2","F4Terminal1");
		F4padBObj1.Name = "Teleporter";
		F4padBObj1.obj3d = F4teleport1b1;
		F4padBObj1.DestinyTeleporter = F4teleport1b2.transform;
		F4padBObj1.CantFire = true;
		F4padBObj1.CantOpenClose = true;
		listaObjeto.Add(F4padBObj1);
		
		Objeto F4doorObj2a = new Objeto("Door","F4Terminal2");
		F4doorObj2a.Name = "Door";		
		F4doorObj2a.obj3d = F4door2a;
		F4doorObj2a._animation = F4door2a.GetComponent<Animation>();
		F4doorObj2a.listaAnimations.Add("DoorOpen");
		F4doorObj2a.listaAnimations.Add("DoorClose");
		F4doorObj2a.HasPassword = false;
		F4doorObj2a.CantFire = true;
		F4doorObj2a.CantActivate = true;
		listaObjeto.Add(F4doorObj2a);
		
		Objeto F4doorObj2b = new Objeto("Door","F4Terminal2b");
		F4doorObj2b.Name = "Door";		
		F4doorObj2b.obj3d = F4door2b;
		F4doorObj2b._animation = F4door2b.GetComponent<Animation>();
		F4doorObj2b.listaAnimations.Add("DoorOpen");
		F4doorObj2b.listaAnimations.Add("DoorClose");
		F4doorObj2b.HasPassword = true;
		F4doorObj2b.CantFire = true;
		F4doorObj2b.CantActivate = true;
		listaObjeto.Add(F4doorObj2b);
		
		Objeto F4superGunObj4a = new Objeto("Super Gun","F4Terminal2");
		F4superGunObj4a.Name = "Super Gun";
		F4superGunObj4a.obj3d = F4superGun2;
		F4superGunObj4a.CantOpenClose = true;
		F4superGunObj4a.CantActivate = true;
		listaObjeto.Add(F4superGunObj4a);
		
		Objeto F4padAObj3 = new Objeto("Teleporter1","F4Terminal3");
		F4padAObj3.Name = "Teleporter";
		F4padAObj3.obj3d = F4teleport3a1;
		F4padAObj3.DestinyTeleporter = F4teleport3a2.transform;
		F4padAObj3.CantFire = true;
		F4padAObj3.CantOpenClose = true;
		listaObjeto.Add(F4padAObj3);
		
		Objeto F4padBObj3 = new Objeto("Teleporter2","F4Terminal3");
		F4padBObj3.Name = "Teleporter";
		F4padBObj3.obj3d = F4teleport3b1;
		F4padBObj3.DestinyTeleporter = F4teleport3b2.transform;
		F4padBObj3.CantFire = true;
		F4padBObj3.CantOpenClose = true;
		listaObjeto.Add(F4padBObj3);
		
		Objeto F4padAObj4 = new Objeto("Teleporter1","F4Terminal4");
		F4padAObj4.Name = "Teleporter";
		F4padAObj4.obj3d = F4teleport4a1;
		F4padAObj4.DestinyTeleporter = F4teleport4a2.transform;
		F4padAObj4.CantFire = true;
		F4padAObj4.CantOpenClose = true;
		listaObjeto.Add(F4padAObj4);
		
		Objeto F4padBObj4 = new Objeto("Teleporter2","F4Terminal4");
		F4padBObj4.Name = "Teleporter";
		F4padBObj4.obj3d = F4teleport4b1;
		F4padBObj4.DestinyTeleporter = F4teleport4b2.transform;
		F4padBObj4.CantFire = true;
		F4padBObj4.CantOpenClose = true;
		listaObjeto.Add(F4padBObj4);
		
		Objeto F4padCObj4 = new Objeto("Teleporter3","F4Terminal4");
		F4padCObj4.Name = "Teleporter";
		F4padCObj4.obj3d = F4teleport4c1;
		F4padCObj4.DestinyTeleporter = F4teleport4c2.transform;
		F4padCObj4.CantFire = true;
		F4padCObj4.CantOpenClose = true;
		listaObjeto.Add(F4padCObj4);
		
		Objeto F4droneGunObj4a = new Objeto("Drone Gun1","F4Terminal4");
		F4droneGunObj4a.Name = "Drone Gun";
		F4droneGunObj4a.obj3d = F4droneGun4a;
		F4droneGunObj4a.CantOpenClose = true;
		F4droneGunObj4a.CantActivate = true;
		listaObjeto.Add(F4droneGunObj4a);
		
		Objeto F4droneGunObj4b = new Objeto("Drone Gun2","F4Terminal4");
		F4droneGunObj4b.Name = "Drone Gun";
		F4droneGunObj4b.obj3d = F4droneGun4b;
		F4droneGunObj4b.CantOpenClose = true;
		F4droneGunObj4b.CantActivate = true;
		listaObjeto.Add(F4droneGunObj4b);
		
		Objeto F4gateObj4a  = new Objeto("Gate","F4Terminal4");
		F4gateObj4a.Name = "Gate";
		F4gateObj4a.obj3d = F4gate4a;
		F4gateObj4a._animation = F4gate4a.GetComponent<Animation>();
		F4gateObj4a.listaAnimations.Add("OpenGate");
		F4gateObj4a.listaAnimations.Add("CloseGate");
		F4gateObj4a.HasPassword = true;
		F4gateObj4a.CantFire = true;
		F4gateObj4a.CantActivate = true;
		listaObjeto.Add(F4gateObj4a);
		
	}
	
	public static Objeto Busca(string id)
	{
		for (int i = 0; i < listaObjeto.Count; i++) {
			if(listaObjeto[i].Id == id)
			{
				return listaObjeto[i];
			}
		}
		
		return null;
	}
}

