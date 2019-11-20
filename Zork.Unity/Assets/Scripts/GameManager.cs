﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zork.common;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFileAssetname = "Zork";

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private TMP_Text ScoreText;

    [SerializeField]
    private TMP_Text LocationText;

    [SerializeField]
    private TMP_Text MovesText;

    private Game Game { get; set; }
    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFileAssetname);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);
        LocationText.text = $" {Game.Player.LocationName}";

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($">{InputService.InputField.text}");
                InputService.ProcessInput();
               ScoreText.text = $"Score: {Game.Player.Score}";
               MovesText.text = $"Moves: {Game.Player.Moves}";
               LocationText.text = $" {Game.Player.LocationName}";
            }
            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }


       if (Game.IsRunning == false)
       {
           #if UNITY_EDITOR
           // Application.Quit() does not work in the editor so
           // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
           UnityEditor.EditorApplication.isPlaying = false;
           #else
        Application.Quit();
       #endif
           
       }
    }
}
