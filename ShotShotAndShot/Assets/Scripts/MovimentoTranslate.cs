using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovimentoTranslate : MonoBehaviour
{
    [SerializeField]

    //Movimento e Interação Personagem
    public float velocidade = 5f;
    float movimentoX = 0;
    Animator anim;
    bool Andando;
    public bool Interagir = false;
    bool Interagir2 = false;

    Vector3 scale;

    //Botões
    public Sprite spr1, spr2;
    public Button botao;
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
#region Movimento e Interagir
    public void Esquerda(){
        scale = transform.localScale;
        movimentoX = -1;
        scale.x = -1;
        transform.localScale = scale;
        
    }
    public void Direita(){
        scale = transform.localScale;
        movimentoX = 1;
        scale.x = 1;
        transform.localScale = scale;
        
    }
    public void Parar(){
        movimentoX = 0;
    }
    public void BotaoInteragir(){
        if (Interagir){
            SceneManager.LoadScene(1);
        }if (Interagir2){
            SceneManager.LoadScene(2);
        }
        
    }
    #endregion
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Desafio")){
            Interagir = true;
            botao.image.sprite = spr2;
        }
        if (collision.CompareTag("Desafio1")){
            Interagir2 = true;
            botao.image.sprite = spr2;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Desafio")){
            Interagir = false;
            botao.image.sprite = spr1;
        }
        if (collision.CompareTag("Desafio1")){
            Interagir2 = false;
            botao.image.sprite = spr1;
        }
    }
}
