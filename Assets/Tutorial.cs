using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public GameObject TutorialUI;
	public Button BotaoInicial;
	
	void Awake()
	{
		if(Application.loadedLevelName == "Fase1Web")
			EstadoJogo.HasTutorial = true;
	}
	
	// Use this for initialization
	void Start () {
		if(EstadoJogo.HasTutorial)
		{
			TutorialUI.SetActive(true);
			BotaoInicial.Select();
		}
		else
			TutorialUI.SetActive(false);
	}
	
	public void FechaTutorial()
	{
		EstadoJogo.HasTutorial = false;
		TutorialUI.SetActive(false);
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
