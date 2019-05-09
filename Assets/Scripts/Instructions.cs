using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    bool endTuto = false;
    public Text tutorial;
    public Text turboInfo;


    private void Start()
    {
        turboInfo.enabled = false;
        tutorial.text = "Use 'WASD' to move";
    }

    void Update()
    {
        if (endTuto == false)
        {
            if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
            {
                tutorial.text = "Use Q to activate turbo";
            }
            else if (Input.GetKeyDown("q"))
            {
                tutorial.text = "";
                endTuto = true;
                turboInfo.enabled = true;
            }
        } 
        
    }
}
