using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class ControlePontuação : MonoBehaviour
{
    public TextMeshProUGUI pontuacao, tempo, acabou;
    int score = 0;
    void Start()
    {
        StartCoroutine(Temporizador(60));
        acabou.enabled = false;
    }
    public void AdicionarPonto(){
        score++;
        pontuacao.text= score.ToString();
    }
    IEnumerator Temporizador(float duracao){
        float TempoRestante = duracao;
        while (TempoRestante>0){
            int minutos = Mathf.FloorToInt(TempoRestante/60);
            int segundos = Mathf.FloorToInt(TempoRestante%60);
            tempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
            yield return new WaitForSeconds(1f);
            TempoRestante--;

        if (TempoRestante == 0)
        {
            Debug.Log("ACABOU");
            acabou.enabled = true;
        }
        }
        tempo.text = "00:00";
    }
}
