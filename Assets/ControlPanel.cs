using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ControlPanel : MonoBehaviour
{

    public Button playButton;
    public Button helpButton;
    public AudioClip[] sons;
    private int indiceTocado;
    public List<int> notasMusica;
    public AudioClip musicaCracker;
    public GameObject soundAnimation;
    public Text info;
    private float startTimePlay;
    private float startWrongRecord;
    bool isPlaying = false;
    bool isRecording = false;
    public GameObject help;
    public Button closeHelp;
    private float StartMenuTime;
    public MoveChar scriptMove;
    public GameObject _objectThis;
    public TerminalGrande terminalControl;
    public UnityEngine.EventSystems.EventSystem eventSystem;
    public CutScene2 cut;
    public GameObject _Trigger;
    public AudioSource musicaAmbiente;
    public AudioClip SolvedSound;

    // Use this for initialization
    void Start()
    {
        soundAnimation.SetActive(false);
        info.text = "";
    }

    void OnEnable()
    {
        StartMenuTime = Time.time;
        musicaAmbiente.volume = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        //gambi
        if ((Time.time - StartMenuTime) > 0.4f && (Time.time - StartMenuTime) < 0.5f) //seleciona depois de um tempinho e libera
            playButton.Select();

        if ((Time.time - startTimePlay) > musicaCracker.length)
        {
            isPlaying = false;
            soundAnimation.SetActive(false);
        }

        if (startWrongRecord != 0 && ((Time.time - startWrongRecord) > 1f))
        {
            info.text = "";
            startWrongRecord = 0;
        }
    }

    public void Record()
    {
        if (!isPlaying)
        {
            indiceTocado = 0;
            info.text = Textos.Recording + "...";
            isRecording = true;
        }
    }

    public void Play()
    {
        if (!isRecording)
        {
            AudioSource.PlayClipAtPoint(musicaCracker, transform.position);
            soundAnimation.SetActive(true);
            info.text = "";
            startTimePlay = Time.time;
            isPlaying = true;
        }
    }

    public void Help()
    {
        if (!isPlaying && !isRecording)
        {
            help.SetActive(true);
            closeHelp.Select();
        }
    }

    public void CloseHelp()
    {
        help.SetActive(false);
        helpButton.Select();
    }

    public void Exit()
    {
        eventSystem.SetSelectedGameObject(null);
        terminalControl.AcabouSairMenu = true;
        scriptMove.PodeMover = true;
        _objectThis.SetActive(false);
        musicaAmbiente.volume = 0.32f;
        if (EstadoJogo.HasPenDrive2)
        {
            Destroy(_Trigger);
            if (cut != null)
            {
                cut.enabled = true;
                cut.StartCutScene = true;
            }
        }
    }

    public void Bass1()
    {
        TocarSom(0);
    }

    public void Bass2()
    {
        TocarSom(1);
    }

    public void Bass3()
    {
        TocarSom(2);
    }

    public void Drum1()
    {
        TocarSom(3);
    }

    public void Drum2()
    {
        TocarSom(4);
    }

    public void Drum3()
    {
        TocarSom(5);
    }

    public void Synth1()
    {
        TocarSom(6);
    }

    public void Synth2()
    {
        TocarSom(7);
    }

    public void Synth3()
    {
        TocarSom(8);
    }

    private void TocarSom(int indice)
    {
        if (!isPlaying)
        {
            AudioSource.PlayClipAtPoint(sons[indice], transform.position);
            if (isRecording)
            {
                int notasTotais = notasMusica.Count - 1;
                int notasFaltantes = notasTotais - indiceTocado;
                if (notasMusica[indiceTocado] == indice)
                {
                    info.text = Textos.Recording + "...\n "+ Textos.GoodCracker +"!\n" + (notasFaltantes).ToString() + Textos.CrackerToGo;
                    if (notasFaltantes == 0)
                    {
                        info.text = Textos.CrackerSuccess;
                        AudioSource.PlayClipAtPoint(SolvedSound, transform.position, 1.5f);
                        EstadoJogo.HasPenDrive2 = true;
                    }
                }
                else
                {
                    info.text = Textos.CrackerWrong;
                    isRecording = false;
                    startWrongRecord = Time.time;
                }

                indiceTocado++;
            }
        }
    }
}
