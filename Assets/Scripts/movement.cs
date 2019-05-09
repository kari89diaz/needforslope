using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float metrosSegundo = 1;
    void Update()
    {
        transform.Translate(0, 0, metrosSegundo * Time.deltaTime);
    }
}
