using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTranslate : MonoBehaviour
{
    public float velocidade = 5f;
    float movimentoX = 0;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (movimentoX != 0){
            //anim.SetBool("Andando", Andando);
        }
        //anim.SetBool("Parada", Parada);
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
