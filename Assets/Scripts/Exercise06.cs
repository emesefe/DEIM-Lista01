using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class Exercise06 : MonoBehaviour
{
    public Color[] color;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.color = color[0];
    }

    public void ChangeColor(int value)
    {
        GetComponent<MeshRenderer>().material.color = color[value];
    }
}
