using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class Exercise08 : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TextMeshProUGUI message;
    
    private string username;

    public void SubmitUsername()
    {
        username = usernameInput.text;

        if (username != "" && username.Trim(' ') != "")
        {
            message.text = $"Hello, {username} and welcome to this amazing adventure";
        }
        else
        {
            usernameInput.text = "";
            message.text = $"Enter a valid username";
        }
    }
}
