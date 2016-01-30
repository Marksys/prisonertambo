using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutScene4a : MonoBehaviour {

    public GameObject Adam;
    public GameObject Laura;

    private CharacterController controller;
    private Animator animator;

    private bool StopWalk = false;
    private bool StartCutScene = false;
    private bool StartTalk = false;

    public Text _nameChar;
    public Text _mensagem;
    public GameObject MensagemUI;

    public Image CanvMens;
    public Image CanvNome;
    public Color CorLaura;
    public Color CorAdam;
    public Color CorDefault;

    private int indiceMens = 0;
    private float nextFire;

    public Transform cameraCutScene;
    public Transform lastCameraTrans;

    public TrocaPlayer trocaPlayer;
    public GameObject HelpUI;
    public Button BotaoHelp;

    void Awake()
    {
        controller = Adam.GetComponent<CharacterController>();
        animator = Adam.GetComponent<Animator>();
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (StartCutScene && !StartTalk)
        {
            Adam.GetComponent<MoveChar>().enabled = false;
            float distance = Vector3.Distance(Adam.transform.position, Laura.transform.position);

            if (distance < 1f)
                StopWalk = true;

            Adam.transform.LookAt(Laura.transform);
            Laura.transform.LookAt(Adam.transform);

            if (!StopWalk)
            {
                Vector3 forward = Adam.transform.TransformDirection(Vector3.forward);
                float curSpeed = 1.5f * (1f / 1.25f);

                controller.SimpleMove(forward * curSpeed);
                animator.SetFloat("Speed", curSpeed);
                animator.SetBool("IsRunning", false);
            }
            else
            {
                animator.SetBool("IsRunning", false);
                animator.SetFloat("Speed", 0f);
                animator.SetFloat("Axis", 0f);
                animator.SetBool("IsStopped", true);
                StartTalk = true;
                Camera.allCameras[0].GetComponent<CameraLook>().enabled = false;
                Camera.allCameras[0].transform.position = cameraCutScene.position;
                Camera.allCameras[0].transform.rotation = cameraCutScene.rotation;
            }
        }

        if (StartTalk)
        {
            MensagemUI.SetActive(true);

            switch (indiceMens)
            {
                case 0:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat1);
                        break;
                    }
                case 1:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat2);
                        break;
                    }
                case 2:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat3);
                        break;
                    }
                case 3:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat4);
                        break;
                    }
                case 4:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat5);
                        break;
                    }
                case 5:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat6);
                        break;
                    }
                case 6:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat7);
                        break;
                    }
                case 7:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat8);
                        break;
                    }
                case 8:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat9);
                        break;
                    }
                case 9:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat10);
                        break;
                    }
                case 10:
                    {
                        MontaDialogo("Laura",Textos.Fase4Chat11);
                        break;
                    }
                case 11:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat12);
                        break;
                    }
                case 12:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat13);
                        break;
                    }
                case 13:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat14);
                        break;
                    }
                case 14:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat15);
                        break;
                    }
                case 15:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat16);
                        break;
                    }
                case 16:
                    {
                        MontaDialogo("Laura", Textos.Fase4Chat17);
                        break;
                    }
                case 17:
                    {
                        MontaDialogo("Adam", Textos.Fase4Chat18);
                        break;
                    }
                case 18:
                    {
                        _nameChar.text = "";
                        _mensagem.text = "";
                        CanvMens.color = CorDefault;
                        CanvNome.color = Color.clear;

                        Camera.allCameras[0].GetComponent<CameraLook>().enabled = true;
                        Camera.allCameras[0].transform.position = lastCameraTrans.position;
                        Camera.allCameras[0].transform.rotation = lastCameraTrans.rotation;

                        StartTalk = false;
                        MensagemUI.SetActive(false);
                        HelpUI.SetActive(true);
                        BotaoHelp.Select();                        

                        break;
                    }
                default:
                    break;
            }

            if (Input.GetButton("Submit") && Time.time > nextFire)
            {
                nextFire = Time.time + 0.5f;
                indiceMens++;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCutScene = true;
        }
    }

    private void MontaDialogo(string Personagem, string texto)
    {
        if (Personagem == "Laura")
        {
            CanvMens.color = CorLaura;
            CanvNome.color = CorLaura;
            _nameChar.text = "Laura";
        }
        else if (Personagem == "Adam")
        {
            CanvMens.color = CorAdam;
            CanvNome.color = CorAdam;
            _nameChar.text = "Adam";
        }

        _mensagem.text = texto;
    }

    public void Close()
    {
        HelpUI.SetActive(false);
        Adam.GetComponent<MoveChar>().enabled = true;
        trocaPlayer.enabled = true;
        Destroy(this);
    }
}
