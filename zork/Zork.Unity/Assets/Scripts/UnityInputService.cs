using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using zork;
using zork.common;

public class UnityInputService : MonoBehaviour, IInputService
{
    public event EventHandler<string> InputReceived;

    public TMP_InputField InputField;

    void Start()
    {
        InputField.Select();
        InputField.ActivateInputField();
    }

    public void ProcessInput()
    {
        InputReceived?.Invoke(this, InputField.text);
    }
}
