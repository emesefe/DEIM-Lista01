using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise09 : MonoBehaviour
{
    public void ToggleLight(bool isActive)
    {
        GetComponent<Light>().enabled = isActive;
    }
}
