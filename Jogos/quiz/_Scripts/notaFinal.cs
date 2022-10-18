using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour
{

    private int idTema;

    public Text ui_txtNota;
    public Text ui_txtInfoTema;

    public GameObject ui_est1;
    public GameObject ui_est2;
    public GameObject ui_est3;

    private int notaF;
    private int acertos;


    // Start is called before the first frame update
    void Start()
    {

        idTema = PlayerPrefs.GetInt("idTema");

        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString() );
        acertos   = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString() );

        ui_txtNota.text = notaF.ToString();
        ui_txtInfoTema.text = "Você acertou " + acertos.ToString() + " perguntas";


        regraEstrelas();

    }

    void regraEstrelas()
    {
        ui_est1.SetActive(false);
        ui_est2.SetActive(false);
        ui_est3.SetActive(false);

        if (notaF == 10)
        {
            ui_est1.SetActive(true);
            ui_est2.SetActive(true);
            ui_est3.SetActive(true);
        }
        else if (notaF >= 7)
        {
            ui_est1.SetActive(true);
            ui_est2.SetActive(true);
            ui_est3.SetActive(false);
        }
        else if (notaF >= 4)
        {
            ui_est1.SetActive(true);
            ui_est2.SetActive(false);
            ui_est3.SetActive(false);
        }
    }

    public void jogarTemaNovamente()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
    
}
