using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Alvo : MonoBehaviour
{
    int linhas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(linhas)
        {
            case 1:
                transform.Translate(0,3.18f,0);
            break;
            case 2:
                transform.Translate(0,0.78f,0);
            break;
            case 3:
                transform.Translate(0,-1.5f,0);
                linhas= 0;
            break;
        }
    }
    public void Cima(){
        linhas+= 1;
    }
}
