using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ControlePontuação : MonoBehaviour
{
    public TextMeshProUGUI pontuacao, tempo;
    int score = 0;
    public void AdicionarPonto(){
        score++;
        pontuacao.text= score.ToString();
    }
    void Update()
    {
        StartCoroutine(Temporizador(300));
    }
    IEnumerator Temporizador(float duracao){
        float TempoRestante = duracao;

        while (TempoRestante>0){
            int minutos = Mathf.FloorToInt(TempoRestante/60);
            int segundos = Mathf.FloorToInt(TempoRestante%60);
            tempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
            yield return new WaitForSeconds(1f);
            TempoRestante--;
        }
        tempo.text = "00:00";
    }
}
