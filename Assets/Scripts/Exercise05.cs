using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using Random = UnityEngine.Random;

public class Exercise05 : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject capsule;

    private List<GameObject> capsulesOnScene = new List<GameObject>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            DeleteAllCapsules();
            GenerateCapsules();
        }
    }

    private void GenerateCapsules()
    {
        foreach (Vector3 pos in positions)
        {
            GameObject c = Instantiate(capsule, pos, Quaternion.identity);
            capsulesOnScene.Add(c);
        }
    }

    private void DeleteAllCapsules()
    {
        foreach (GameObject c in capsulesOnScene)
        {
            Destroy(c);
        }
        capsulesOnScene.Clear();
    }
}
