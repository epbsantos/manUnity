using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class comandosBasicos : MonoBehaviour
{

    public Animator transitionAnim;


    public void carregaCena(string nomeCena)
    {
        StartCoroutine(LoadScene(nomeCena));
    }

    IEnumerator LoadScene(string n)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(n);
    }

    public void resetarPontos()
    {
        PlayerPrefs.DeleteAll();
    }

}
