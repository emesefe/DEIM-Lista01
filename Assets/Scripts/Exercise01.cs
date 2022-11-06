using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI randomNumberText;

    private float randomNumber;
    [SerializeField] private float min = 0;
    [SerializeField] private float max = 10;

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(min, max);
        randomNumberText.text = $"{randomNumber:F3}";
    }
}
