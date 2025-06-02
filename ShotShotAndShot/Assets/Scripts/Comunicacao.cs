using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comunicacao : MonoBehaviour
{
    public Sprite spr;
    public string[] falas;
    public float VelFala = 0.5f;
    private MovimentoTranslate MT;
    void Start()
    {
        MT = GetComponent<MovimentoTranslate>();
    }
    void Update()
    {
        if (MT.Interagir == true && CompareTag("NPC"))
        {
            
        }
    }
}
