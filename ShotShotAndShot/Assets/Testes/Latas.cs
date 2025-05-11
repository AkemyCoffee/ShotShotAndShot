using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latas : MonoBehaviour
{
    public GameObject garrafa;
    void Start()
    {
       StartCoroutine(TempoInstanciar());
    }
    IEnumerator TempoInstanciar(){
        while (true){
            float esperar = Random.Range(1, 3);
            yield return new WaitForSeconds(esperar);

            Instantiate(garrafa, transform.position, transform.rotation);
        }
    }
}
