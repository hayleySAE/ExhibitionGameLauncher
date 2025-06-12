using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuPopulator : MonoBehaviour
{
    [SerializeField]
    public List<GameInformation> games;
    [SerializeField]
    public GameButton buttonPrefab;

    //TODO: Move to the game panel
    public TMP_Text descriptionField;
    public TMP_Text teamField;
    public Image gameIconField;
    public GameLaunchButton launchButton;

    private void Start()
    {
        Populate();
    }

    private void Populate()
    {
        foreach (var game in games)
        {
            GameButton button = Instantiate(buttonPrefab, transform, false);
            button.SetGame(game);
            //Will become 'gamePanel.UpdateFields'
            button.OnClick(UpdateFields);
        }
    }
    
    //TODO: Move to game panel
    public void UpdateFields(GameInformation game)
    {
        gameIconField.sprite = game.icon;
        descriptionField.text = game.description;
        //TODO: Better concatenation
        teamField.text = game.studentNames.ToString();
        launchButton.filePath = game.filePath;
    }
}
