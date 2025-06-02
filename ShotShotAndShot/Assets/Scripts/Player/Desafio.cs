using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio : MonoBehaviour
{
    private MovimentoTranslate MT;
    public GameObject Distintivo;
    void Start()
    {
        MT = GameObject.Find("Player").GetComponent<MovimentoTranslate>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Distintivo.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Distintivo.SetActive(false);
        }
    }
}
