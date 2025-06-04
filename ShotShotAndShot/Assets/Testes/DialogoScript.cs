using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoScript : MonoBehaviour
{
    public Text Nome;
    public Text Dialogo;
    public Image PersonagemImagem;
    public GameObject PainelDialogo;

    public FalasDialogo[] linhas;
    private int IndexAtual = 0;

    void Start()
    {
        MostreLinhas();

    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            ProximaLinha();
        }
    }
    public void ProximaLinha()
    {
        IndexAtual++;

        if (IndexAtual < linhas.Length)
        {
            MostreLinhas();
        }
        else
        {
            PainelDialogo.SetActive(false);
        }
    }
    public void MostreLinhas()
    {
        PainelDialogo.SetActive(true);
        Nome.text = linhas[IndexAtual].PersonagemNome;
        Dialogo.text = linhas[IndexAtual].Falas;

        if (linhas[IndexAtual].portrait != null)
        {
            PersonagemImagem.sprite = linhas[IndexAtual].portrait;
        }
    }
}
