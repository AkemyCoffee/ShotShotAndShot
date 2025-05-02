using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoCorrida : MonoBehaviour
{
    public float vel = 5;
    float movimentoX = 0;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.right * movimentoX * vel * Time.deltaTime);
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
