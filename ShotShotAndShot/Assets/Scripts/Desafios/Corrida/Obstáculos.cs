using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstáculos : MonoBehaviour
{
    float VelBaixo;
    void Start()
    {
        
    }

    private void FixedUpdate(){
        transform.Translate(0, VelBaixo, 0);
    }
    private void ResetarPosicao(){
        float randomX = Random.Range(-9.4f, 9.4f);
        transform.position = new Vector2(randomX, 7f);
    }
    void Update()
    {
        
    }
}
