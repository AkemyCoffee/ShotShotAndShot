using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraGarrafa : MonoBehaviour
{
    public bool Acerte = false;
    public GameObject garrafa;
    void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.CompareTag("Balao")){
            Acerte = true;
            print("bb");
        }else{
            Acerte = false;
        }
        */
        garrafa = collision.gameObject;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.CompareTag("Balao")){
            Acerte = false;
        }
        */
        if (collision.gameObject == garrafa){
            garrafa = null;
        }
    }
    public void Acertou(){
        /*
        if (Acerte){
            Destroy(garrafa);
            Debug.Log("POW");
        }*/
        if (garrafa != null){
            Destroy(garrafa);
            garrafa = null;
        }
    }

}
