using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotação : MonoBehaviour
{
    public float vel = 75f;
    private float anguloAtual = 0f;
    bool Girando = true;
    void Update()
    {
        float rotacao = vel * Time.deltaTime;
        if (Girando){
            if (anguloAtual < 90f){
              transform.Rotate(0,0, rotacao);
              anguloAtual += rotacao;
            }
            else {
                anguloAtual = 90f;
                Girando = false;
            }
        }
        else{
            if (anguloAtual > 0f){
                transform.Rotate(0,0, -rotacao);
                anguloAtual -= rotacao;
            }
            else{
                anguloAtual = 0f;
                Girando = true;
            }
        }
    }
}
