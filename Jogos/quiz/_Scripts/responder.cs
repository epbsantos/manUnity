using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class responder : MonoBehaviour
{

    private int idTema;

    public Text ui_pergunta;
    public Text ui_resA;
    public Text ui_resB;
    public Text ui_resC;
    public Text ui_resD;
    public Text ui_infoResposta;

    
    public string[] perguntas;
    public string[] altA;
    public string[] altB;
    public string[] altC;
    public string[] altD;
    public string[] corretas;
    

    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private int notaFinal;



    // Start is called before the first frame update
    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");

        idPergunta = 0;
        questoes = perguntas.Length;

        updateUI();
    }

    public void resposta(string alternativa)
    {
             if (alternativa == "A")
        {
            if (altA[idPergunta] == corretas[idPergunta]) acertos++;
        }
        else if (alternativa == "B") {
            if (altB[idPergunta] == corretas[idPergunta]) acertos++;
        }
        else if (alternativa == "C") {
            if (altC[idPergunta] == corretas[idPergunta]) acertos++;
        }
        else if (alternativa == "D") {
            if (altD[idPergunta] == corretas[idPergunta]) acertos++;
        }

        proximaPergunta();

    }

    void proximaPergunta()
    {
        idPergunta++;

        if (idPergunta <= (questoes-1))
        {
            updateUI();
        }
        else
        {
            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);

            if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()) )
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal );
                PlayerPrefs.SetInt("acertos" +idTema.ToString(), (int)acertos );
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);

            SceneManager.LoadScene("notaFinal");
        }
        
    }

    void updateUI()
    {
        ui_pergunta.text = perguntas[idPergunta];
        ui_resA.text = altA[idPergunta];
        ui_resB.text = altB[idPergunta];
        ui_resC.text = altC[idPergunta];
        ui_resD.text = altD[idPergunta];

        ui_infoResposta.text = "Respondendo " +
                               (idPergunta + 1).ToString() +
                               " de " +
                               questoes.ToString();
    }

}
