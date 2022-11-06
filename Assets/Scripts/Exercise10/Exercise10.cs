using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.IMGUI.Controls;
using Random = UnityEngine.Random;

public class Exercise10 : MonoBehaviour
{
    public float xBound = 9;
    public float yBound = 4;
    public float zBound = 1;
    public GameObject sphere;
    public TextMeshProUGUI pointsText;

    private float totalSpheres = 30;
    private int totalPoints;

    private void Start()
    {
        for (int i = 0; i < totalSpheres; i++)
        {
            GameObject s = Instantiate(sphere, GenerateRandomPosBetweenBounds(), Quaternion.identity);
            s.transform.SetParent(transform);
        }

        totalPoints = 0;
        DisplayTotalPoints();
    }

    private Vector3 GenerateRandomPosBetweenBounds()
    {
        float x = Random.Range(-xBound, xBound);
        float y = Random.Range(-yBound, yBound);
        float z = Random.Range(-zBound, zBound);
        return new Vector3(x, y, z);
    }

    private void DisplayTotalPoints()
    {
        pointsText.text = $"Points: {totalPoints}";
    }

    public void AddPoint()
    {
        totalPoints++;
        DisplayTotalPoints();
    }
}
