using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garrafa : MonoBehaviour
{
    GameObject garrafa;
    public float move = 2;
    void Update()
    {
        transform.Translate(-Vector2.right * move * Time.deltaTime);
        if (transform.position.y < -11){
            Destroy(garrafa);
        }
    }
   
}
