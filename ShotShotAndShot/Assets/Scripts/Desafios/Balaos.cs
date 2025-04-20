using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balaos : MonoBehaviour
{
    public GameObject[] baloes;
    public float CimaVel = 0.05f;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        QualBalao();
    }
    private void OnMouseDown()
    {
        anim.SetTrigger("Pocou");

        StartCoroutine(Espere(1));
        
    }
    private void FixedUpdate()
    {
        transform.Translate(0, CimaVel, 0);
    }
    private void ResetarPosicao(){
        float randomX = Random.Range(-9.4f, 9.4f);
        transform.position = new Vector2(randomX, -8f);

    }
    void QualBalao(){
        int RandomBalao = Random.Range(0, baloes.Length);
        
    }
    IEnumerator Espere(int segundos){

        CimaVel = 0;
        yield return new WaitForSeconds(segundos);
        anim.ResetTrigger("Pocou");

        ResetarPosicao();

        CimaVel = 0.05f;

    }
    
}
