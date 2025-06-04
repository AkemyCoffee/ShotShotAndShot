using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogoScript : MonoBehaviour
{
    public Image PersonagemEsquerda;
    public Image PersonagemDireita;
    public TextMeshProUGUI Nome;
    public TextMeshProUGUI Dialogo;
    public GameObject PainelDialogo;


    public FalasDialogo[] Falas;
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

    public void MostreLinhas()
    {
        PainelDialogo.SetActive(true);
        FalasDialogo linha = Falas[IndexAtual];


        Nome.text = Falas[IndexAtual].PersonagemNome;
        Dialogo.text = linha.Falas;

        GameObject.FindGameObjectWithTag("Player").GetComponent<MovimentoTranslate>().velocidade = 0;


        if (linha.portraitEsquerda != null)
        {
            PersonagemEsquerda.sprite = linha.portraitEsquerda;
        }
        if (linha.portraitDireita != null)
        {
            PersonagemDireita.sprite = linha.portraitDireita;
        }

        if (linha.PrincipalFala)
        {
            PersonagemEsquerda.color = Color.white;
            PersonagemDireita.color = new Color(1, 1, 1, 0.5f);
        }
        else
        {
            PersonagemDireita.color = Color.white;
            PersonagemEsquerda.color = new Color(1, 1, 1, 0.5f);
        }

    }
    public void ProximaLinha()
    {
        IndexAtual++;

        if (IndexAtual < Falas.Length)
        {
            MostreLinhas();
        }
        else
        {
            PainelDialogo.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<MovimentoTranslate>().velocidade = 5;
        }
    }
}
