using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Camera camaraMain;
    public Camera camaraCaida;
    public Object player;

    private void Start()
    {
        camaraMain.enabled = true;
        camaraCaida.enabled = false;
    }
    private void OnTriggerEnter(Collider camaras)
    {
        if (camaras.gameObject.CompareTag("Player"))
        {
            camaraMain.enabled = false;
            camaraCaida.enabled = true;
        }
           
    }
}
