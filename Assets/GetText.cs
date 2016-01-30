using UnityEngine;
using UnityEngine.UI;

public class GetText : MonoBehaviour {

    public string Texto;
    private Text TextoUI;
    string numLevel;

    void Start () {
        TextoUI = GetComponent<Text>();

        if (Texto == "MenuLevel" || Texto == "Bass" || Texto == "Drum" || Texto == "Synth")
            numLevel = TextoUI.text;

        TextoUI.text = Textos.PegaTexto(Texto);

        if (Texto == "MenuLevel" || Texto == "Bass" || Texto == "Drum" || Texto == "Synth")
            TextoUI.text += " " + numLevel;

        if(Texto == "Quality") //colocar a qualidade selecionada
        {
            int qualidade = QualitySettings.GetQualityLevel();

            if (qualidade == 0)
                TextoUI.text += " " + Textos.PegaTexto("Low");
            else if (qualidade == 3)
                TextoUI.text += " " + Textos.PegaTexto("Medium");
            else if (qualidade == 5)
                TextoUI.text += " -> " + Textos.PegaTexto("High");
        }
    }
}

