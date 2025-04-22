using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    int linhas = 1;
    Vector2 posalvo;
    public float distacia = 5f;
    public float vel = 2f;
    void Start()
    {
        posalvo = transform.position;
    }
    void Update()
    {
        float movimento =Mathf.PingPong(Time.time * vel, distacia);
        transform.position = new Vector2(posalvo.x + movimento, posalvo.y);
    }
    
    public void Cima(){
        linhas+= 1;
        switch(linhas)
        {
            case 1:
                posalvo.y = 3.18f;
                transform.position = posalvo;
            break;
            case 2:
                posalvo.y = 0.78f;
                transform.position = posalvo;
            break;
            case 3:
                posalvo.y =-1.5f;
                transform.position = posalvo;
                linhas= 0;
            break;
        }
    }
}
