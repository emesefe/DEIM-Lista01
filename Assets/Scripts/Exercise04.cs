using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise04 : MonoBehaviour
{
    public void ChangeScale(float value)
    {
        transform.localScale = value * Vector3.one;
    }
}
