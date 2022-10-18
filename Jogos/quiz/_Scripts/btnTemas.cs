using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnTemas : MonoBehaviour
{
    public int idTema;

    public GameObject est1;
    public GameObject est2;
    public GameObject est3;

    private int notaF;

    // Start is called before the first frame update
    void Start()
    {
        
        notaF = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());

        regraEstrelas();

    }

    void regraEstrelas()
    {
        est1.SetActive(false);
        est2.SetActive(false);
        est3.SetActive(false);

        if (notaF == 10)
        {
            est1.SetActive(true);
            est2.SetActive(true);
            est3.SetActive(true);
        }
        else if (notaF >= 7)
        {
            est1.SetActive(true);
            est2.SetActive(true);
            est3.SetActive(false);
        }
        else if (notaF >= 4)
        {
            est1.SetActive(true);
            est2.SetActive(false);
            est3.SetActive(false);
        }
    }


}
