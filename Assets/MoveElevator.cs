using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveElevator : MonoBehaviour {

	public GameObject baseElevador;
	public GameObject Adam;
	private bool StartCutScene = false;
	Vector3 posFinal = new Vector3(0,4,0);
	public GameObject UINextFase;
	public Button buttonNext;
	
	void Start () 
	{
		
	}	
	
	void FixedUpdate () 
	{
		if(StartCutScene)
		{			
			Adam.GetComponent<MoveChar>().PodeMover = false;
			Adam.transform.position = Vector3.Lerp(Adam.transform.position, Adam.transform.position + posFinal, Time.deltaTime /8f);
			baseElevador.transform.position = Vector3.Lerp (baseElevador.transform.position, baseElevador.transform.position + posFinal, Time.deltaTime/8f);
			
			if(baseElevador.transform.position.y >= posFinal.y)
			{
				StartCutScene = false;
				UINextFase.SetActive(true);
				buttonNext.Select();
			}	
		}	
	}
	
	public void OnTriggerEnter(Collider other)
	{	
		if(other.tag == "Player")
		{
			StartCutScene = true;
		}		
	}
	
	public void NextFase()
	{
		if(Application.loadedLevelName == "Fase1")
			Application.LoadLevel("Fase2");
		else if(Application.loadedLevelName == "Fase2")
			Application.LoadLevel("Fase3");
		else if(Application.loadedLevelName == "Fase3")
			Application.LoadLevel("Fase4");
		else if(Application.loadedLevelName == "Fase4")
			Application.LoadLevel("MainMenu");
		else if(Application.loadedLevelName == "Fase1Web")
			Application.LoadLevel("Fase2Web");
		else if(Application.loadedLevelName == "Fase2Web")
			Application.LoadLevel("Fase3Web");
		else if(Application.loadedLevelName == "Fase3Web")
			Application.LoadLevel("MainMenuWeb");
	}
}
