using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CL : MonoBehaviour
{
    public Rigidbody SpringBall;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            SpringBall.AddForce(Vector3.up * 1600);
        }

    
    }

}

