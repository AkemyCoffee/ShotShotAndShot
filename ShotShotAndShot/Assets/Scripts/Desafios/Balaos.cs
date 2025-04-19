using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balaos : MonoBehaviour
{
    public float CimaVel = 0.05f;
    void Update()
    {

    }
    private void OnMouseDown()
    {
        ResetarPosicao();
    }
    private void FixedUpdate()
    {
        transform.Translate(0, CimaVel, 0);
    }
    private void ResetarPosicao(){
        float randomX = Random.Range(-9.4f, 9.4f);

        transform.position = new Vector2(randomX, -8f);
    }
    
}
