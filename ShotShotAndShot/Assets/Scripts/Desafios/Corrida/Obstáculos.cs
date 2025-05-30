using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstáculos : MonoBehaviour
{
    public float VelBaixo = 0.12f;
    public float randomX, crescendo = 1f;
    public GameObject OutroObstaculo, Bandeira;
    public Sprite[] SprObs;
    SpriteRenderer sr;
    Vector3 crescer;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        StartCoroutine(Espere(2));
        StartCoroutine(Captura(3));
        if (transform.position.y < -4)
        {
            sr.sortingOrder = 2;
        }
        crescer = Vector3.one * crescendo * Time.deltaTime;
        if (transform.position.y < -10)
        {
            ResetarPosicao();
        }
        switch (randomX)
        {
            case 0:
                transform.position = new Vector2(-6, transform.position.y);
                transform.localScale += crescer;
                break;
            case 1:
                transform.position = new Vector2(0, transform.position.y);
                transform.localScale += crescer;
                break;
            case 2:
                transform.position = new Vector2(6, transform.position.y);
                transform.localScale += crescer;
                break;
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(0, -VelBaixo, 0);
    }
    private void ResetarPosicao()
    {
        int escolher = Random.Range(0, SprObs.Length);
        sr.sprite = SprObs[escolher];

        randomX = Random.Range(0, 3);
        transform.position = new Vector2(randomX, 8f);
        transform.localScale = Vector3.one;
        sr.sortingOrder = -2;
    }
    // Couratine Para o segundo obstáculo aparecer
    IEnumerator Espere(int segundos)
    {
        yield return new WaitForSeconds(segundos);
        OutroObstaculo.SetActive(true);
    }
    IEnumerator Captura(int segundos)
    {
       yield return new WaitForSeconds(segundos);
        Bandeira.SetActive(true);
    }
}
