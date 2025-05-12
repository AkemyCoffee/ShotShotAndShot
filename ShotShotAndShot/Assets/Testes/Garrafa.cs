using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garrafa : MonoBehaviour
{
    public float move = 2;
    
    void Update()
    {
        transform.Translate(-Vector2.right * move * Time.deltaTime);
        if (transform.position.x < -11){
            Destroy(gameObject);
        }
    }
    
}
