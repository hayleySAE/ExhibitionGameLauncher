using System;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    private GameInformation _gameInfo;
    private Action<GameInformation> _onClick;
    [SerializeField]
    private TMPro.TMP_Text _text;

    public void SetGame(GameInformation gameInfo)
    {
        _gameInfo = gameInfo;
        //set button text
        _text.text = _gameInfo.name;
    }

    public void OnClick(Action<GameInformation> onClick)
    {
        _onClick = onClick;
    }

    public void Click()
    {
        _onClick?.Invoke(_gameInfo);
    }
}
