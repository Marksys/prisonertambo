using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public GameObject mainMenu;
    public Button buttonInicial;

	public GameObject levelSelect;
    public Button buttonLevel1;    
	
    public GameObject optionSelect;
    public Button buttonOption1;

    // Use this for initialization
    void Start () {
		buttonInicial.Select();
        EstadoJogo.PodeMostrarExit = true;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Exit()
	{
		Application.Quit();
	}
	
	public void NewGame()
	{
		EstadoJogo.HasTutorial = true;
		Application.LoadLevel ("Fase1");
	}
	
	public void Level1()
	{
		Application.LoadLevel ("Fase1");
	}
	
	public void Level2()
	{
		Application.LoadLevel ("Fase2");
	}
	
	public void Level3()
	{
		Application.LoadLevel ("Fase3");
	}

    public void Level4()
    {
        Application.LoadLevel("Fase4");
    }

    public void Level1Web()
	{
		EstadoJogo.HasTutorial = true;
		Application.LoadLevel ("Fase1Web");
	}
	
	public void Level2Web()
	{
		Application.LoadLevel ("Fase2Web");
	}
	
	public void Level3Web()
	{
		Application.LoadLevel ("Fase3Web");
	}
	
	public void LevelSelect()
	{
		levelSelect.SetActive(true);
		mainMenu.SetActive(false);
		buttonLevel1.Select();
	}

    public void OptionsSelect()
    {
        optionSelect.SetActive(true);
        mainMenu.SetActive(false);
        buttonOption1.Select();
    }

    public void Back()
	{
		mainMenu.SetActive(true);
		levelSelect.SetActive(false);
        optionSelect.SetActive(false);
        buttonInicial.Select();
	}

    public void English()
    {
        Textos.Idioma = 0;
        PlayerPrefs.SetInt("Lang", 0);
        Application.LoadLevel("MainMenu");
    }

    public void Portugues()
    {
        Textos.Idioma = 1;
        PlayerPrefs.SetInt("Lang", 1);
        Application.LoadLevel("MainMenu");
    }

    public void Low()
    {
        QualitySettings.SetQualityLevel(0, true);
        Application.LoadLevel("MainMenu");
    }

    public void Medium()
    {
        QualitySettings.SetQualityLevel(3, true);
        Application.LoadLevel("MainMenu");
    }

    public void High()
    {
        QualitySettings.SetQualityLevel(5, true);
        Application.LoadLevel("MainMenu");
    }
}
