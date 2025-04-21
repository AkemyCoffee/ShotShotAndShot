using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentoTranslate : MonoBehaviour
{
    [SerializeField]
    public float velocidade = 5f;
    float movimentoX = 0;
    Animator anim;
    
    bool Andando;
    public bool Interagir = false;
    bool Interagir2 = false;
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
        }
        if (collision.gameObject.name== "Desafio1 (1)"){
            Interagir2 = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Desafio")){
            Interagir = false;
        }
        if (collision.gameObject.name== "Desafio1"){
            Interagir2 = false;
        }
    }
}
