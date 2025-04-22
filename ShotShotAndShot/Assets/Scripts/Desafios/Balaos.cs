using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Balaos : MonoBehaviour
{
    public TextMeshProUGUI acabou;
    public float CimaVel;
    bool acertou = false;
    bool Passou = false;
    Animator anim;
    AudioSource AS;
    void Start()
    {
        anim = GetComponent<Animator>();
        AS = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (acertou){
            anim.SetBool("Acertou", acertou);
            GetComponent<Collider2D>().enabled= false;
        }
        else{
            anim.SetBool("Acertou", acertou);
            GetComponent<Collider2D>().enabled= true;
        }
        PassouTela();
    }
    private void OnMouseDown()
    {
        AS.Play();
        acertou = true;
        StartCoroutine(Espere(1));
    }
    private void FixedUpdate(){
        transform.Translate(0, CimaVel, 0);
    }
    private void ResetarPosicao(){
        float randomX = Random.Range(-9.4f, 9.4f);
        transform.position = new Vector2(randomX, -10f);
    }
    IEnumerator Espere(int segundos){
        CimaVel = 0;
        yield return new WaitForSeconds(segundos);
        acertou = false;
        ResetarPosicao();
        CimaVel = Random.Range(0.05f, 0.15f);
    }
    public void PassouTela(){
        if(transform.position.y> 5){
            acabou.enabled = true;
        }
    }
}
