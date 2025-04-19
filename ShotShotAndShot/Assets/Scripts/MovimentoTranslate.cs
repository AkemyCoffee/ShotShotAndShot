using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MovimentoTranslate : MonoBehaviour
{
    public float velocidade = 5f;
    float movimentoX = 0;
    float DirX = 0;
    Animator anim;
    bool Andando, Idle;
    bool Vira = true;
    


    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
        //Direcao();
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
        //DirX = -1;
    }
    public void Direita(){
        Vector3 scale = transform.localScale;
        movimentoX = 1;
        scale.x = 1;
        transform.localScale = scale;
        //DirX = 1;
    }
    public void Parar(){
        movimentoX = 0;
    }
    /*
    void Direcao(){
        if (Vira && DirX < 0){
            Virar();
        }
        if (!Vira && DirX > 0){
            Virar();
        }
    }
    void Virar(){
        Vira = !Vira;
        transform.Rotate(0,180,0);
    }
    */
}
