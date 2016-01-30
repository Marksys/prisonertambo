using UnityEngine;
using System.Collections;

public class Botao : MonoBehaviour {

	// restart
	public void Restart () {
		Application.LoadLevel(Application.loadedLevel);
	}
	
	public void Sair () {
		Application.Quit();
	}
}
