using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PontuaçãoBalao : MonoBehaviour
{
    public ControlePontuação CP;
    void OnMouseDown()
    {
        CP.AdicionarPonto();
    }
}
