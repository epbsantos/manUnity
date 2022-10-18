using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class temas
{
    public string nome;
    public Questoes[] questoes;
}

[System.Serializable]
public class temaRaiz
{
    public temas[] tema;
}
