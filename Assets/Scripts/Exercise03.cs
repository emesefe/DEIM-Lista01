using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise03 : MonoBehaviour
{
    public float xBound = 9;
    public float yBound = 4;
    public float zBound = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = GenerateRandomPosBetweenBounds();
        }
    }

    private Vector3 GenerateRandomPosBetweenBounds()
    {
        float x = Random.Range(-xBound, xBound);
        float y = Random.Range(-yBound, yBound);
        float z = Random.Range(-zBound, zBound);
        return new Vector3(x, y, z);
    }
}
