using System.Reflection;
using UnityEngine;

public static class Textos
{
    static Textos()
    {
        Textos.Idioma = PlayerPrefs.GetInt("Lang");
    }

    public static string PegaTexto(string propriedade)
    {
        PropertyInfo propertyInfo = typeof(Textos).GetProperty(propriedade);
        string _texto = (string)propertyInfo.GetValue(null, null);
        return _texto;
    }

    public static int Idioma;//default ingles

    //textos gerais    
    public static string Yes
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Yes";
                    }
                case 1:
                    {
                        return "Sim";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string No
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "No";
                    }
                case 1:
                    {
                        return "Não";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string GetPenDrive
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Get Floppy Disk";
                    }
                case 1:
                    {
                        return "Pegar Disquete";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string UseTerminal
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Use Terminal";
                    }
                case 1:
                    {
                        return "Usar Terminal";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CannotUseThisTerminal
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "- I have to find a way to use this thing.";
                    }
                case 1:
                    {
                        return "- Preciso arrumar um jeito de ativar isso.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string UseControlTerminal
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Use Control Panel";
                    }
                case 1:
                    {
                        return "Usar Painel de Controle";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CannotHackTerminal
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "- I have to find a way to hack this terminal.";
                    }
                case 1:
                    {
                        return "- Preciso dar um jeito de hackear este terminal.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string FaseMainMenu
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Main Menu";
                    }
                case 1:
                    {
                        return "Menu Principal";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string FaseNextLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Next Floor";
                    }
                case 1:
                    {
                        return "Próximo Andar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Help
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Help";
                    }
                case 1:
                    {
                        return "Ajuda";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Exit
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Exit";
                    }
                case 1:
                    {
                        return "Sair";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Close
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Close";
                    }
                case 1:
                    {
                        return "Fechar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Stranger
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Stranger";
                    }
                case 1:
                    {
                        return "Desconhecido";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //cracker painel
    public static string GoodCracker
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Good";
                    }
                case 1:
                    {
                        return "Correto";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CreatingCracker
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Creating Cracker";
                    }
                case 1:
                    {
                        return "Criar Cracker";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CrackerWrong
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Wrong note \n Stop Recording...";
                    }
                case 1:
                    {
                        return "Nota errada \n Gravação interrompida...";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CrackerSuccess
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Cracker has been created with success!";
                    }
                case 1:
                    {
                        return "Cracker foi criado com sucesso!"; ;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string CrackerToGo
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return " to go!";
                    }
                case 1:
                    {
                        return " faltantes.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string HelpTextCracker
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "--- How to Create a Cracker ---\n\n\n" +
                        "-Get a feel for the notes. (ex: Bass, Drums, Synth, etc.)\n\n" +
                        "-Press 'Play' when you are ready. Listen to the music carefully.\n\n" +
                        "-It is now time to record.c\n\n" +
                        "-Press 'Record' and play the music pressing the correlating notes.\n\n" +
                        "- Once you have played the score without mistakes,\n" +
                        "the cracker will be created.";
                    }
                case 1:
                    {
                        return "--- Como criar um Cracker ---\n\n\n" +
                        "-Primeiro teste o som das notas Baixo, Bateria e Teclado.\n\n" +
                        "-Depois aperte 'Tocar' e escute a musica com atenção.\n\n" +
                        "-Agora é hora de gravar!\n\n" +
                        "-Aperte 'Gravar' e tente achar a nota correta.\n\n" +
                        "- Quando você acertar todas as notas da música, o cracker\n" +
                        "será criado.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Bass
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Bass";
                    }
                case 1:
                    {
                        return "Baixo";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Drum
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Drum";
                    }
                case 1:
                    {
                        return "Bateria";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Synth
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Keyboard";
                    }
                case 1:
                    {
                        return "Teclado";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Play
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Play";
                    }
                case 1:
                    {
                        return "Tocar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Record
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Record";
                    }
                case 1:
                    {
                        return "Gravar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Recording
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Recording";
                    }
                case 1:
                    {
                        return "Gravando";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Language
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Language";
                    }
                case 1:
                    {
                        return "Idioma";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Quality
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Quality";
                    }
                case 1:
                    {
                        return "Qualidade";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Low
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Low";
                    }
                case 1:
                    {
                        return "Baixa";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Medium
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Medium";
                    }
                case 1:
                    {
                        return "Média";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string High
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "High";
                    }
                case 1:
                    {
                        return "Alta";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //textos menu principal
    public static string MenuNewGame
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "New Game";
                    }
                case 1:
                    {
                        return "Novo Jogo";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuLevelSelect
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Level Select";
                    }
                case 1:
                    {
                        return "Selecionar Fase";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuExit
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Exit";
                    }
                case 1:
                    {
                        return "Sair do Jogo";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Level";
                    }
                case 1:
                    {
                        return "Fase";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuBackEsc
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Back to main menu?";
                    }
                case 1:
                    {
                        return "Voltar para o menu principal?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuBack
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Back";
                    }
                case 1:
                    {
                        return "Voltar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string MenuOptions
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Options";
                    }
                case 1:
                    {
                        return "Opções";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //textos fase 1
    public static string Fase1Tutorial
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "---- Tutorial ----\n\n" +
                        "Adam Tambo is a prisoner, help him use his hacker skills to escape!\n\n" +
                        "Commands:\n" +
                        "Arrows - Move\n" +
                        "Enter - Action\n" +
                        "Spacebar - Run\n" +
                        "Esc - Back to Main Menu";
                    }
                case 1:
                    {
                        return "---- Tutorial ----\n\n" +
                       "Adam Tambo é um prisioneiro e precisa utilizar suas habilidades de hacker para escapar.\n\n" +
                       "Comandos:\n" +
                       "Setas - Movimento\n" +
                       "Enter - Ação\n" +
                       "Barra de Espaço - Correr\n" +
                       "Esc - Volta para o Menu";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase1FimLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "---- Congratulations ----\n\n\n" +
                        "1st Floor Cleared.\n\n\n" +
                        "Reference your notes to help \n Adam escape from prison!";
                    }
                case 1:
                    {
                        return "---- Parabéns ----\n\n\n" +
                          "1º Andar finalizado.\n\n\n" +
                          "Continue achando dicas para tentar\n" +
                          "tirar Adam desta prisão.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase1HowToHack
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retHowHack = " --- How to Hack ---\n\n";
                        retHowHack += " - Choose between three actions: 'call','cmd' and 'exec'.\n";
                        retHowHack += " - First 'call' an object (ex. door, gate, etc.)\n";
                        retHowHack += " - Make your 'cmd' (ex: open, close, fire, etc.) \n";
                        retHowHack += " - Use the 'EXEC' action for special tasks. \n";
                        retHowHack += " - For example: If an object has a password, \ncrack it using the 'EXEC' action";
                        retHowHack += " \n\n-Ps. Whoever wrote this is a friend! =)\n";
                        return retHowHack;
                    }
                case 1:
                    {
                        string retHowHack = " --- Como Hackear ---\n\n";
                        retHowHack += " - Escolha entre três ações: 'call','cmd' e 'exec'.\n";
                        retHowHack += " - Primeiro chame um objeto com 'call'.\n";
                        retHowHack += " - Depois faça um comando com 'cmd' como 'open', 'close' ou 'fire'. \n";
                        retHowHack += " - Se o objeto tiver um Password, você precisa quebrá-lo. \n";
                        retHowHack += " - É só chamar o objeto e executar com 'exec' \n o programa 'cracker.exe'. \n";
                        retHowHack += " \n\n-Ps. Quem escreveu este bilhete é uma pessoa amiga! =)\n";
                        return retHowHack;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase1Friend1
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - I hope you've enjoyed the gift I've left in your cell.\n";
                        retFriendNote1 += " - I knew you would figure out how to use it.\n";
                        retFriendNote1 += " \n\n-Ps. The cracker and object may not be in the same terminal! =)\n";
                        return retFriendNote1;
                    }
                case 1:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - Eu espero que você tenha gostado do presente que eu deixei em sua cela.\n";
                        retFriendNote1 += " - Eu sabia que você saberia como usá-lo.\n";
                        retFriendNote1 += " \n\n-Ps. Algumas vezes o cracker e objeto não estão no mesmo terminal! =)\n";
                        return retFriendNote1;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase1Friend2
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote2 = "\n\n\n";
                        retFriendNote2 += " - I'm waiting for you on the 2nd Floor.\n";
                        retFriendNote2 += " \n\n-Ps. Try placing the gate at diferent angles.\n";
                        retFriendNote2 += " Then fire using the drone gun. =)\n";
                        return retFriendNote2;
                    }
                case 1:
                    {
                        string retFriendNote2 = "\n\n\n";
                        retFriendNote2 += " - Estou te esperando no 2º Andar.\n";
                        retFriendNote2 += " \n\n-Ps. Tente diferentes posições com o objeto 'gate'.\n";
                        retFriendNote2 += " Depois tente atirar com objeto 'drone gun'. =)\n";
                        return retFriendNote2;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //textos fase 2
    public static string Fase2FimLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "---- Congratulations ----\n\n\n" +
                        "2st Floor Cleared.\n\n\n" +
                        "Adam has met Laura. \n" +
                        "Where does it lead to?";
                    }
                case 1:
                    {
                        return "---- Parabéns ----\n\n\n" +
                          "2º Andar finalizado.\n\n\n" +
                          "Adam conheceu Laura.\n" +
                          "Onde isso o levará?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Friend1
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - Welcome to the 2nd Floor.\n\n";
                        retFriendNote1 += " \n\n-Ps. You can move balls! =)\n";
                        return retFriendNote1;
                    }
                case 1:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - Bem vindo ao 2º Andar.\n\n";
                        retFriendNote1 += " \n\n-Ps. Você pode empurrar alguns objetos! =)\n";
                        return retFriendNote1;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Friend2
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote2 = "\n\n\n\n";
                        retFriendNote2 += " - Take your time or hurry up, the choice is yours, just don't be late!\n";
                        retFriendNote2 += " \n\n ;)";
                        return retFriendNote2;
                    }
                case 1:
                    {
                        string retFriendNote2 = "\n\n\n\n";
                        retFriendNote2 += " - Faça no seu tempo ou se apresse, a escolha é sua, só não se atrase.\n";
                        retFriendNote2 += " \n\n ;)";
                        return retFriendNote2;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Friend3
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote3 = "\n\n\n\n";
                        retFriendNote3 += " - You can utilize objects from the previous room.\n";
                        return retFriendNote3;
                    }
                case 1:
                    {
                        string retFriendNote3 = "\n\n\n\n";
                        retFriendNote3 += " - Você pode utilizar um objeto da sala anterior.\n";
                        return retFriendNote3;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat1
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Hello Mr. Tambo.\nMy name is Laura Pitu.";
                    }
                case 1:
                    {
                        return "Olá Sr. Tambo.\nMeu nome é Laura Pitu.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat2
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I am the one who has been sending you those notes.";
                    }
                case 1:
                    {
                        return "Sou eu quem estou enviando aquelas mensagens.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat3
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Hello 'Friend'.";
                    }
                case 1:
                    {
                        return "Manjei!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat4
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Please, just call me Adam.";
                    }
                case 1:
                    {
                        return "E pode me chamar de Adam.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat5
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Ok, Adam. I understand that you probably have many questions.";
                    }
                case 1:
                    {
                        return "Certo Adam. Eu sei que você deve ter muitas perguntas.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat6
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "But now is not the time, we must hurry.";
                    }
                case 1:
                    {
                        return "Mas temos que nos apressar.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat7
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "But...";
                    }
                case 1:
                    {
                        return "Mas...";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat8
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I've told you, is not the time.";
                    }
                case 1:
                    {
                        return "Te avisei que precisamos nos apressar!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat9
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Ok. What do you need?";
                    }
                case 1:
                    {
                        return "Beleza, o que você precisa então?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat10
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "We cannot continue to hack without a new cracker.";
                    }
                case 1:
                    {
                        return "Os próximos terminais não podem ser hackeados sem um cracker novo.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat11
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "And I am not able to create another.";
                    }
                case 1:
                    {
                        return "E eu não posso criar outro.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat12
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "What do we do now?";
                    }
                case 1:
                    {
                        return "E agora?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat13
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "You can create a new cracker in the control panel.";
                    }
                case 1:
                    {
                        return "Você pode criar um novo cracker naquele painel de controle.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat14
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "So you've been waiting for me to create this new cracker?";
                    }
                case 1:
                    {
                        return "Você estava me esperando só para criar este cracker?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat15
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Yes. Unfortunately, I do not understand the music aspect of creation.";
                    }
                case 1:
                    {
                        return "Sim. Eu não entendo essa parte musical necessária para criá-lo.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat16
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Go to that terminal. Once you are finished, come talk to me.";
                    }
                case 1:
                    {
                        return "Agora vá para aquele terminal, assim que terminar, eu falo com você.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat17
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Got it.";
                    }
                case 1:
                    {
                        return "Beleza.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat1b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Great! You did it!";
                    }
                case 1:
                    {
                        return "Ótimo, você conseguiu!.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat2b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "What now?";
                    }
                case 1:
                    {
                        return "E agora?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat3b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "This cracker will help you.";
                    }
                case 1:
                    {
                        return "Utilize este novo cracker nos próximos terminais para continuar.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat4b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Hey, do you know why I'm here?";
                    }
                case 1:
                    {
                        return "Você tem ideia do porquê de eu estar aqui?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat5b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "No, I don't.";
                    }
                case 1:
                    {
                        return "Não tenho.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat6b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I'll meet you on the 4th Floor.";
                    }
                case 1:
                    {
                        return "Agora vá! Estarei te esperando no 4º Andar";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat7b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Use my notes to help you.";
                    }
                case 1:
                    {
                        return "Continue lendo minhas mensagens.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase2Chat8b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "All right.";
                    }
                case 1:
                    {
                        return "Bacana!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //textos fase 3
    public static string Fase3FimLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "---- Congratulations ----\n\n\n" +
                        "3rd Floor Cleared.\n\n\n" +
                        "Adam hasn't found anything on this floor.\n" +
                        "Let's keep moving.";
                    }
                case 1:
                    {
                        return "---- Parabéns ----\n\n\n" +
                          "3º Andar finalizado.\n\n\n" +
                          "Adam não achou nada de importante neste andar\n" +
                          " e precisar seguir seu caminho.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase3Friend1
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - Welcome to the 3rd Floor.\n\n";
                        retFriendNote1 += " \n\n-Ps. Teleporting makes me sick. =(\n";
                        return retFriendNote1;
                    }
                case 1:
                    {
                        string retFriendNote1 = "\n\n\n";
                        retFriendNote1 += " - Bem vindo ao 3º Andar.\n\n";
                        retFriendNote1 += " \n\n-Ps. Teletransportar me deixa enjoada. =(\n";
                        return retFriendNote1;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase3Friend2
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote2 = "\n\n\n";
                        retFriendNote2 += " - This room will be tougher than the last.\n";
                        retFriendNote2 += " \n\n =|";
                        return retFriendNote2;
                    }
                case 1:
                    {
                        string retFriendNote2 = "\n\n\n";
                        retFriendNote2 += " - Esta sala vai ser complicada!\n";
                        retFriendNote2 += " \n\n =|";
                        return retFriendNote2;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase3Friend3
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        string retFriendNote3 = "\n\n\n";
                        retFriendNote3 += "  - I hope you have got this terminal first.\n\n =)\n";
                        return retFriendNote3;
                    }
                case 1:
                    {
                        string retFriendNote3 = "\n\n\n\n";
                        retFriendNote3 += " - Eu espero que você tenha chegado neste terminal primeiro.\n\n =)\n";
                        return retFriendNote3;
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }

    //textos fase 4
    public static string Fase4FimLevel
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Thank you for playing the First Chapter!\n\n" +
                            "Please give me your feedback \n" +
                            "to help me finish the game!\n\n" +
                            "marcos@marksys.com.br\n" +
                            "=)";
                    }
                case 1:
                    {
                        return "Obrigado por jogar o Capítulo 1!\n\n" +
                            "Agora preciso do seu feedback\n" +
                            "me ajude a terminar este jogo.\n\n" +
                            "marcos@marksys.com.br\n" +
                            "=)";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4AjudaLaura
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "\nNow you can select your character\n\n"+
                            "Push TAB to switch between Laura and Adam.";
                    }
                case 1:
                    {
                        return "\nAgora você pode selecionar seu personagem\n\n" +
                           "Aperte TAB para trocar entre Laura e Adam.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat1
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "For what ya search, you'll find a way. Hold yourself!";
                    }
                case 1:
                    {
                        return "Aquilo que você está procurando, dará certo broto!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat2
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Oh my gosh. You are so 70's!";
                    }
                case 1:
                    {
                        return "Meu Deus, você é tão anos 70.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat3
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Why wouldn't I be? We are in 1975, can you dig it?";
                    }
                case 1:
                    {
                        return "E por que não seria, broto? Se estamos em 1975";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat4
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "This is 1995.";
                    }
                case 1:
                    {
                        return "Estamos em 1995.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat5
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "That's impossible, I was just at a disco last night!";
                    }
                case 1:
                    {
                        return "Isto é impossível! Eu estava na discoteca na noite passada!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat6
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Are you saying that before waking in this prison, you were at a dance club?";
                    }
                case 1:
                    {
                        return "Você esta dizendo que antes de acordar aqui nesta prisão, você estava em uma balada?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat7
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "A disco, but yes.";
                    }
                case 1:
                    {
                        return "Isso, em uma discoteca.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat8
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "How is that even possible?";
                    }
                case 1:
                    {
                        return "Como isso é possível?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat9
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Yesterday I was at the movies watching a cowboy doll talking...";
                    }
                case 1:
                    {
                        return "Ontem eu estava no cinema assitindo um boneco vaqueiro falante...";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat10
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I have no idea what you are talking about.";
                    }
                case 1:
                    {
                        return "Não estou entendendo o que você está dizendo.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat11
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Nevermind.Forget it.";
                    }
                case 1:
                    {
                        return "Deixa quieto.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat12
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "What now?";
                    }
                case 1:
                    {
                        return "E agora?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat13
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "This terminal can help us command the giant gun that will help us get to the other side.";
                    }
                case 1:
                    {
                        return "Precisamos acessar este terminal para usar aquela arma gigante para atravessar.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat14
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "How are we going to do that?";
                    }
                case 1:
                    {
                        return "Como vamos fazer isso?";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat15
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I think we need to fill those empty boxes.";
                    }
                case 1:
                    {
                        return "Acho que precisamos colocar algo nestas caixas.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat16
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "And today is your lucky day!";
                    }
                case 1:
                    {
                        return "E hoje é seu dia de sorte!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat17
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "I'm going to help you.";
                    }
                case 1:
                    {
                        return "Porque eu vou te ajudar.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat18
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Sugar and spice!";
                    }
                case 1:
                    {
                        return "Xuxu beleza!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat1b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "Comeback now!!!";
                    }
                case 1:
                    {
                        return "Volte agora!!!";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
    public static string Fase4Chat2b
    {
        get
        {
            switch (Idioma)
            {
                case 0:
                    {
                        return "If you ignore this warning, you may regret.";
                    }
                case 1:
                    {
                        return "Se você ignorar meu aviso, você irá se arrepender.";
                    }
                default:
                    {
                        return "";
                    }
            }
        }
    }
}
