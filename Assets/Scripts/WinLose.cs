using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public Canvas winlose;
    public GameObject car;
    public Pause endScene;

    private void Awake()
    {
        
    }
    private void Start()
    {
        winlose.enabled = false;
    }

    private void OnTriggerEnter(Collider canvas)
    {
        car = GameObject.FindGameObjectWithTag("Player");
        endScene = endScene.GetComponent<Pause>();

        if (canvas.gameObject.CompareTag("Player"))
        {
            winlose.enabled = true;
            endScene.pause = true;
        }
    }
}
