using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutScene4b : MonoBehaviour {

	public GameObject Player;
	public GameObject BoxFim;

	private Animator animator;
	private MoveChar MoveChar;
		
	public bool StartCutScene = false;
	private bool StartTalk = false;
		
	public Text _nameChar;
	public Text _mensagem;
	public GameObject MensagemUI;
	
	public Image CanvMens;
	public Image CanvNome;
	public Color CorLaura;
	public Color CorAdam;
	public Color CorDefault;	

	private float nextFire;
	
	public TrocaPlayer trocaPlayer;
	public GameObject HelpUI; 
	public Button BotaoHelp;

    public GameObject Plasma;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	float startTimeMove;
    Vector3 posFinal = new Vector3(0, 10, 0);
    void FixedUpdate ()
	{
		if(StartCutScene && !StartTalk)
		{            
            animator.SetBool("IsRunning", false);
            animator.SetFloat("Speed", 0f);
            animator.SetFloat("Axis", 0f);
            animator.SetBool("IsStopped", true);
            Player.transform.position = Vector3.Lerp(Player.transform.position, Player.transform.position + posFinal, Time.deltaTime / 8f);
            Plasma.transform.position = new Vector3(Player.transform.position.x-0.5f, Player.transform.position.y, Player.transform.position.z + 0.5f);
            MoveChar.enabled = false;

            Player.transform.LookAt(BoxFim.transform);

            if (Player.transform.position.y >= posFinal.y)
            {                
				StartTalk = true;              
			}
		}
		
		if(StartTalk)
		{
            _nameChar.text = "";
			_mensagem.text = "";
			CanvMens.color = CorDefault;
			CanvNome.color = Color.clear;

            StartTalk = false;
            StartCutScene = false;
            MensagemUI.SetActive(false);
			HelpUI.SetActive(true);
			BotaoHelp.Select();
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
	
	public void OnTriggerEnter(Collider other)
	{	
		if(other.tag == "Player")
		{
			StartCutScene = true;
            Player = other.gameObject;
            animator = Player.GetComponent<Animator>();
            MoveChar = Player.GetComponent<MoveChar>();

            MoveChar.PodeMover = false;

            Plasma.transform.position = Player.transform.position;
            Plasma.SetActive(true);
        }		
	}
	
	public void Close()
	{
		HelpUI.SetActive(false);
        Player.GetComponent<MoveChar>().enabled = true;
		trocaPlayer.enabled = true;
		Destroy(this);
	}
}
