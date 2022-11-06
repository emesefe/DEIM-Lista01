using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise02 : MonoBehaviour
{
    public int number;
    
    private TextMeshProUGUI message;

    private void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string evenOdd = number % 2 == 0 ? "par" : "impar";
            message.text = $"El número {number} es {evenOdd}";
        }
    }
}
