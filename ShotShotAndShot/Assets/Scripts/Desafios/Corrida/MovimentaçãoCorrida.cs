using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoCorrida : MonoBehaviour
{
    public float vel = 1;
    public float movimentoX = 0;
    void Start()
    {
        
    }
    void Update()
    {
        switch(movimentoX){
            case -1:
                transform.position = new Vector2(-6, transform.position.y);
            break;
            case 0:
                transform.position = new Vector2(0, transform.position.y);
            break;
            case 1:
                transform.position = new Vector2(6, transform.position.y);
            break;
        }

        if (movimentoX > 1){
            movimentoX = 1;
        }
        if (movimentoX < -1){
            movimentoX = -1;
        }
    }
    public void Esquerda(){
        movimentoX--;
    }
    public void Direita(){
        movimentoX++;
    }
    public void Parar(){
        movimentoX = 0;
    }
}
