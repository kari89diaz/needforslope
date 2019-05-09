using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    public Transform objetivo;
    
    void Update()
    {
        transform.LookAt(objetivo);
    }
}
