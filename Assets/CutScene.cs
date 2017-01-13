using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CutScene : MonoBehaviour
{

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
            Adam.GetComponent<MoveChar>().PodeMover = false;
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
            }
        }

        if (StartTalk)
        {
            MensagemUI.SetActive(true);

            switch (indiceMens)
            {
                case 0:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat1);
                        break;
                    }
                case 1:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat2);
                        break;
                    }
                case 2:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat3);
                        break;
                    }
                case 3:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat4);
                        break;
                    }
                case 4:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat5);
                        break;
                    }
                case 5:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat6);
                        break;
                    }
                case 6:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat7);
                        break;
                    }
                case 7:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat8);
                        break;
                    }
                case 8:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat9);
                        break;
                    }
                case 9:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat10);
                        break;
                    }
                case 10:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat11);
                        break;
                    }
                case 11:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat12);
                        break;
                    }
                case 12:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat13);
                        break;
                    }
                case 13:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat14);
                        break;
                    }
                case 14:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat15);
                        break;
                    }
                case 15:
                    {
                        MontaDialogo("Laura", Textos.Fase2Chat16);
                        break;
                    }
                case 16:
                    {
                        MontaDialogo("Adam", Textos.Fase2Chat17);
                        break;
                    }
                case 17:
                    {
                        _nameChar.text = "";
                        _mensagem.text = "";
                        CanvMens.color = CorDefault;
                        CanvNome.color = Color.clear;
                        Adam.GetComponent<MoveChar>().PodeMover = true;
                        StartTalk = false;
                        MensagemUI.SetActive(false);
                        Destroy(this);
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
}
