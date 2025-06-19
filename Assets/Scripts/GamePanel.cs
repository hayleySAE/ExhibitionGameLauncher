using System;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    public TMP_Text descriptionField;
    public TMP_Text teamField;
    public Image gameIconField;
    public Button launchButton;
    //public GameLaunchButton launchButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void UpdateFields(GameInformation game)
    {
        gameIconField.sprite = game.icon;
        descriptionField.text = game.description;
        //TODO: Better concatenation
        teamField.text = "";
        foreach (var studentName in game.studentNames)
        {
            teamField.text += studentName.name + "  :  " + studentName.role + "\n";
        }
        launchButton.onClick.RemoveAllListeners();
        launchButton.onClick.AddListener(() => LaunchGame(game.filePath));
        //launchButton.filePath = game.filePath;
    }

    public void LaunchGame(string filePath)
    {
        if (filePath.Length > 0)
        {
            print(filePath);
            Process load = new Process();
            load.StartInfo.FileName = filePath;//for executable files
            load.Start();
        }
    }
}
