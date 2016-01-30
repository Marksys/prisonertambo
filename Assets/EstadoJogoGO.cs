using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EstadoJogoGO : MonoBehaviour {

	public GameObject Mensagem;
    public GameObject MensagemConfirmaSair;
    public Button BotaoSairNao;
    public Color corFonteBotao;
    public UnityEngine.EventSystems.EventSystem eventSystem;
    public MoveChar _movechar;

    public GameObject F1door;
	public GameObject F1door2;
	public GameObject F1gate2;
	public GameObject F1droneGun2;
	public GameObject F1door3;	
	public GameObject F1droneGun3;
	public GameObject F1door4;	
	public GameObject F1droneGun4a;
	public GameObject F1droneGun4b;
	public GameObject F1gate4;
	
	public GameObject F2door1;
	public GameObject F2teleport1a;
	public GameObject F2teleport1b;
	public GameObject F2door2;
	public GameObject F2teleport2a1;
	public GameObject F2teleport2a2;
	public GameObject F2teleport2b1;
	public GameObject F2teleport2b2;	
	public GameObject F2door3;
	public GameObject F2teleport3a;
	public GameObject F2teleport3b;
	public GameObject F2droneGun3;
	public GameObject F2door4;
	
	public GameObject F3door1;
	public GameObject F3door2a;
	public GameObject F3door2b;
	public GameObject F3teleport2a1;
	public GameObject F3teleport2b1;
	public GameObject F3teleport2c1;
	public GameObject F3teleport2a2;
	public GameObject F3teleport2b2;
	public GameObject F3teleport2c2;
	public GameObject F3droneGun2a;
	public GameObject F3gate2a;
	public GameObject F3droneGun2b;
	public GameObject F3gate2b;
	public GameObject F3door3;
	
	public GameObject F4door1;
	public GameObject F4teleport1a1;
	public GameObject F4teleport1b1;
	public GameObject F4teleport1a2;
	public GameObject F4teleport1b2;
	public GameObject F4door2a;
	public GameObject F4door2b;
	public GameObject F4superGun2;
	public GameObject F4teleport3a1;
	public GameObject F4teleport3b1;
	public GameObject F4teleport3a2;
	public GameObject F4teleport3b2;
	public GameObject F4teleport4a1;
	public GameObject F4teleport4b1;
	public GameObject F4teleport4a2;
	public GameObject F4teleport4b2;
	public GameObject F4teleport4c1;
	public GameObject F4teleport4c2;
	public GameObject F4gate4a;
	public GameObject F4droneGun4a;
	public GameObject F4droneGun4b;	
	
	// Use this for initialization
	void Awake () {
	
		//seta cor da fonte do primeiro botao
		EstadoJogo.corFonteTexto = corFonteBotao;
		
		//soh carregar os metodos dos GO de cada fase para o EstadoJogo
		if(Application.loadedLevelName == "Fase1" || Application.loadedLevelName == "Fase1New")
		{
			//Fase1
			EstadoJogo.F1door = F1door;
			
			EstadoJogo.F1door2 = F1door2;
			EstadoJogo.F1gate2 = F1gate2;
			
			EstadoJogo.F1droneGun2 = F1droneGun2;
			EstadoJogo.F1door3 = F1door3;
			EstadoJogo.F1droneGun3 = F1droneGun3;
			
			EstadoJogo.F1door4 = F1door4;
			EstadoJogo.F1droneGun4a = F1droneGun4a;
			EstadoJogo.F1droneGun4b = F1droneGun4b;
			EstadoJogo.F1gate4 = F1gate4;
			
			EstadoJogo.StartF1();
		}
		else if(Application.loadedLevelName == "Fase2" || Application.loadedLevelName == "Fase2New")
		{
			//Fase2
			EstadoJogo.F2door1 = F2door1;
			EstadoJogo.F2teleport1a = F2teleport1a;
			EstadoJogo.F2teleport1b = F2teleport1b;
			
			EstadoJogo.F2door2 = F2door2;
			EstadoJogo.F2teleport2a1 = F2teleport2a1;
			EstadoJogo.F2teleport2a2 = F2teleport2a2;
			EstadoJogo.F2teleport2b1 = F2teleport2b1;
			EstadoJogo.F2teleport2b2 = F2teleport2b2;
			
			EstadoJogo.F2door3 = F2door3;
			EstadoJogo.F2teleport3a = F2teleport3a;
			EstadoJogo.F2teleport3b = F2teleport3b;
			EstadoJogo.F2droneGun3 = F2droneGun3;
			
			EstadoJogo.F2door4 = F2door4;
			
			EstadoJogo.StartF2();
		}
		else if(Application.loadedLevelName == "Fase3" || Application.loadedLevelName == "Fase3Web")
		{
			//Fase3
			EstadoJogo.F3door1 = F3door1;
			EstadoJogo.F3door2a = F3door2a;
			EstadoJogo.F3door2b = F3door2b;
			EstadoJogo.F3teleport2a1 = F3teleport2a1;
			EstadoJogo.F3teleport2b1 = F3teleport2b1;
			EstadoJogo.F3teleport2c1 = F3teleport2c1;
			EstadoJogo.F3teleport2a2 = F3teleport2a2;
			EstadoJogo.F3teleport2b2 = F3teleport2b2;
			EstadoJogo.F3teleport2c2 = F3teleport2c2;
			EstadoJogo.F3teleport2a2 = F3teleport2a2;
			EstadoJogo.F3teleport2b2 = F3teleport2b2;
			EstadoJogo.F3teleport2c2 = F3teleport2c2;
			EstadoJogo.F3droneGun2a = F3droneGun2a;
			EstadoJogo.F3gate2a = F3gate2a;
			EstadoJogo.F3droneGun2b = F3droneGun2b;
			EstadoJogo.F3gate2b = F3gate2b;
			EstadoJogo.F3door3 = F3door3;
			EstadoJogo.StartF3();
		}
		else if(Application.loadedLevelName == "Fase4")
		{
			//Fase4
			EstadoJogo.F4door1 = F4door1;
			EstadoJogo.F4teleport1a1 = F4teleport1a1;
			EstadoJogo.F4teleport1b1 = F4teleport1b1;
			EstadoJogo.F4teleport1a2 = F4teleport1a2;
			EstadoJogo.F4teleport1b2 = F4teleport1b2;
			EstadoJogo.F4door2a = F4door2a;
			EstadoJogo.F4door2b = F4door2b;
			EstadoJogo.F4superGun2 = F4superGun2;
			EstadoJogo.F4teleport3a1 = F4teleport3a1;
			EstadoJogo.F4teleport3b1 = F4teleport3b1;
			EstadoJogo.F4teleport3a2 = F4teleport3a2;
			EstadoJogo.F4teleport3b2 = F4teleport3b2;
			EstadoJogo.F4teleport4a1 = F4teleport4a1;
			EstadoJogo.F4teleport4b1 = F4teleport4b1;
			EstadoJogo.F4teleport4a2 = F4teleport4a2;
			EstadoJogo.F4teleport4b2 = F4teleport4b2;
			EstadoJogo.F4teleport4c1 = F4teleport4c1;
			EstadoJogo.F4teleport4c2 = F4teleport4c2;
			EstadoJogo.F4gate4a = F4gate4a;
			EstadoJogo.F4droneGun4a = F4droneGun4a;
			EstadoJogo.F4droneGun4b = F4droneGun4b;
			EstadoJogo.StartF4();
		}
	}
	
	void Start()
	{
		Mensagem.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Menu") && EstadoJogo.PodeMostrarExit)
		{
            MensagemConfirmaSair.SetActive(true);           
            BotaoSairNao.Select();
            _movechar.PodeMover = false;
            _movechar.holderTerminal.SetActive(false);
        }
    }

    public void SairMenu()
    {
        if (Application.loadedLevelName.Contains("Web"))
        {
            if (Application.loadedLevelName != "Fase1Web")//tirando o esc da fase 1, se quiser colocar, soh comentar
                Application.LoadLevel("MainMenuWeb");
        }
        else
            Application.LoadLevel("MainMenu");
    }

    bool fecharMenu;
    public void FecharSairMenu()
    {
        MensagemConfirmaSair.SetActive(false);
        eventSystem.SetSelectedGameObject(null);
        _movechar.PodeMover = true;
    }
}
