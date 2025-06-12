using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuPopulator : MonoBehaviour
{
    [SerializeField]
    public List<GameInformation> games;
    [SerializeField]
    public GameObject buttonPrefab;

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
            GameObject button = Instantiate(buttonPrefab, transform, true);
            button.GetComponent<GameButton>().SetGame(game);
        }
    }
    
    //TODO: event which updates the panel and the button's launch path.
    public void UpdateFields(GameInformation game)
    {
        gameIconField.sprite = game.icon;
        descriptionField.text = game.description;
        //TODO: Better concatenation
        teamField.text = game.studentNames.ToString();
        launchButton.filePath = game.filePath;
        launchButton.LaunchGame();
    }
}
