using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<Exercise10>().AddPoint();
        Destroy(gameObject);
    }
}
