using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise07 : MonoBehaviour
{
    public void ChangeAlpha(float value)
    {
        Color color = GetComponent<MeshRenderer>().material.color;
        color.a = value;
        GetComponent<MeshRenderer>().material.color = color;
    }
}
