using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public bool turbo = false;
    public bool turboCoolDown = false;
    public bool inputEnabled = true;
    public float metrosSegundo;
    public float girar;


    void Update()
    {
        if (inputEnabled == true)
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(0, 0, metrosSegundo * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                transform.Translate(0, 0, -metrosSegundo * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                transform.Rotate(0, girar * Time.deltaTime, 0);
            }
            if (Input.GetKey("a"))
            {
                transform.Rotate(0, -girar * Time.deltaTime, 0);
            }
            if (turboCoolDown == false)
            {
                if (Input.GetKeyDown("q"))
                {
                    if (turbo == false)
                    {
                        turbo = true;
                        Invoke("TurboAct", 3); //lo que dura el turbo
                    }
                }
            }
            
        }
    }

    void TurboAct()
    {
        turbo = false;
        turboCoolDown = true;
        Invoke("TurboDes", 2); //lo que dura el cooldown del turbo
    }

    void TurboDes()
    {
        turboCoolDown = false;
    }
}
