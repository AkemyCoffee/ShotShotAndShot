using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTranslate : MonoBehaviour
{
    public float velocidade = 10f;
    float movimentoX = 0;
    void Update()
    {
        transform.Translate(Vector2.right * movimentoX * velocidade * Time.deltaTime);
    }
    public void Esquerda(){
        movimentoX = -1;
    }
    public void Direita(){
        movimentoX = 1;
    }
    public void Parar(){
        movimentoX = 0;
    }
}
