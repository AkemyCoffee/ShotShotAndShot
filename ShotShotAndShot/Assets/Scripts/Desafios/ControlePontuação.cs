using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlePontuação : MonoBehaviour
{
    public TextMeshProUGUI pontuacao;
    int score = 0;
    public void AdicionarPonto(){
        score++;
        pontuacao.text= score.ToString();
    }
}
