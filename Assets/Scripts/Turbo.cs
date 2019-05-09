using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turbo : MonoBehaviour
{
    playerMovement playmov;
    public Text turboCount;
    public float timeTurbo = 3;
    public float timeCoolDown = 2;

    private void Awake()
    {
        playmov = GetComponent<playerMovement>();
    }

    void Update()
    {
        switch (playmov.turbo)
        {
            case false:
                playmov.metrosSegundo = 6;
                playmov.girar = 18;
                timeCoolDown -= Time.deltaTime;
                if (timeCoolDown <= 0)
                {
                    turboCount.color = Color.red;
                    turboCount.text = "Turbo";
                    timeCoolDown = 2;
                }
                
                break;

            case true:
                playmov.metrosSegundo = 12;
                playmov.girar = 36;
                turboCount.color = Color.white;
                timeTurbo -= Time.deltaTime;
                turboCount.text = timeTurbo.ToString("f0");
                if (timeTurbo <= 0)
                {
                    turboCount.text = "";
                    timeTurbo = 3;
                }
                break;
        }
    }
}
