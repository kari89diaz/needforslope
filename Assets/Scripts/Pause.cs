using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    playerMovement plmov;
    public float time = 1;
    public bool pause = false;

    private void Awake()
    {
        plmov = GetComponent<playerMovement>();
    }
    void Update()
    {
        Time.timeScale = time;

        if (Input.GetKeyDown("p"))
        {
            if (pause == false)
            {
                pause = true;

            }
            else
            {
                pause = false;

            }
        }
        if (pause == true)
        {
            time = 0;
            plmov.inputEnabled = false;
        }
        else
        {
            time = 1;
            plmov.inputEnabled = true;

        }
    }
}
