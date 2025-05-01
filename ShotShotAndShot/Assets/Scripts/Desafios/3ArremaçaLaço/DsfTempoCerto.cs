using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DsfTempoCerto : MonoBehaviour
{
    public GameObject balaprefab;
    public Transform posBala;
    Rigidbody2D rig;
    public float vel = 500f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0){
        Touch toque = Input.GetTouch(0);    
        if (toque.phase == TouchPhase.Began)
        Atirar();
        }
    }
    void Atirar(){
        GameObject bala = Instantiate(balaprefab, posBala.position, posBala.rotation);
        rig = bala.GetComponent<Rigidbody2D>();
        rig.AddForce(posBala.right * vel, ForceMode2D.Impulse);
    }
}
