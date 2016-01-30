using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutScene4c : MonoBehaviour
{
    public bool StartCutScene = false;

    public Text _nameChar;
    public Text _mensagem;
    public GameObject MensagemUI;

    public Image CanvMens;
    public Image CanvNome;
    public Color CorLaura;
    public Color CorAdam;
    public Color CorNewChar;
    public Color CorDefault;

    public int version;
    private bool MessageShowed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (StartCutScene && !MessageShowed)
        {
            MensagemUI.SetActive(true);

            if (version == 0)
            {
                MontaDialogo("Stranger", Textos.Fase4Chat1b);
            }
            else if (version == 1)
            {
                MontaDialogo("Stranger", Textos.Fase4Chat2b);
            }

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
        else if (Personagem == "Stranger")
        {
            CanvMens.color = CorNewChar;
            CanvNome.color = CorNewChar;
            _nameChar.text = Textos.Stranger;
        }

        _mensagem.text = texto;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCutScene = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _nameChar.text = "";
            _mensagem.text = "";
            CanvMens.color = CorDefault;
            CanvNome.color = Color.clear;
            MensagemUI.SetActive(false);
            StartCutScene = false;
            MessageShowed = true;
        }
    }
}
