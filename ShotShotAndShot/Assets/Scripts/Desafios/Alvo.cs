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

    // Update is called once per frame
    void Update()
    {
        float movimento =Mathf.PingPong(Time.time * vel, distacia);
        transform.position = new Vector2(posalvo.x + movimento, posalvo.y);
    }
    
    public void Cima(){
        Debug.Log("ApertouCima");
        linhas+= 1;
        switch(linhas)
        {
            case 1:
                posalvo.y = 3.18f;
                Debug.Log(linhas);
                transform.position = posalvo;
            break;
            case 2:
                posalvo.y = 0.78f;
                transform.position = posalvo;
                Debug.Log(linhas);
            break;
            case 3:
                posalvo.y =-1.5f;
                transform.position = posalvo;
                Debug.Log(linhas);
                linhas= 0;
            break;
        }
    }
    public void Baixo(){
        Debug.Log("ApertouBaixo");
        /*
        linhas-= 1;
        switch(linhas)
        {
            case 1:
                posalvo.x = 3.18f;
                Debug.Log(linhas);
                linhas= 4;
            break;
            case 2:
                posalvo.x = 0.78f;
                Debug.Log(linhas);
            break;
            case 3:
                posalvo.x =-1.5f;
                Debug.Log(linhas);
            break;
            
        }
        */
    }
    /*
    void OnMouseDown()
    {
        if (CompareTag("Cima")){
            Debug.Log("ApertouCima");
        }
        if (CompareTag("Baixo")){
            Debug.Log("ApertouBaixo");
        }
    }
    */
}
