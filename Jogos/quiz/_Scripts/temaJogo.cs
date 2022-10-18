using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temaJogo : MonoBehaviour
{
    public Button btnPlay;
    public Text txtNomeTema;

    public GameObject infoTema;
    public Text txtInfoTema;
    public GameObject infoEst1;
    public GameObject infoEst2;
    public GameObject infoEst3;

    public string[] nomeTema;

    private int idTema;
    private int notaF;
    private int acertos;



    // Start is called before the first frame update
    void Start()
    {
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];

        infoTema.SetActive(false);
        infoEst1.SetActive(false);
        infoEst2.SetActive(false);
        infoEst3.SetActive(false);
        txtInfoTema.text = "";

        btnPlay.interactable = false;

    }

    public void selecioneTema(int id)
    {
        idTema = id;
        PlayerPrefs.SetInt("idTema", idTema);

        txtNomeTema.text = nomeTema[idTema];
        infoTema.SetActive(true);

        notaF = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

        txtInfoTema.text = "Acertou " + acertos + " questões";

        regraEstrelas();

        btnPlay.interactable = true;
    }

    public void jogar()
    {
        SceneManager.LoadScene( "T" + idTema.ToString() );
    }

    void regraEstrelas()
    {

        infoEst1.SetActive(false);
        infoEst2.SetActive(false);
        infoEst3.SetActive(false);

        if (notaF == 10)
        {
            infoEst1.SetActive(true);
            infoEst2.SetActive(true);
            infoEst3.SetActive(true);
        }
        else if (notaF >= 7)
        {
            infoEst1.SetActive(true);
            infoEst2.SetActive(true);
            infoEst3.SetActive(false);
        }
        else if (notaF >= 4)
        {
            infoEst1.SetActive(true);
            infoEst2.SetActive(false);
            infoEst3.SetActive(false);
        }

    }


}
