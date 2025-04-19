using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MovimentoTranslate : MonoBehaviour
{
    public float velocidade = 5f;
    float movimentoX = 0;
    Animator anim;
    bool Andando;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (movimentoX != 0){
            Andando = true;
            anim.SetBool("Andando", Andando);
        }
        else{
            Andando = false;
            anim.SetBool("Andando", Andando);
        }
        transform.Translate(Vector2.right * movimentoX * velocidade * Time.deltaTime);
    }
    public void Esquerda(){
        Vector3 scale = transform.localScale;
        movimentoX = -1;
        scale.x = -1;
        transform.localScale = scale;
    }
    public void Direita(){
        Vector3 scale = transform.localScale;
        movimentoX = 1;
        scale.x = 1;
        transform.localScale = scale;
    }
    public void Parar(){
        movimentoX = 0;
    }
}
