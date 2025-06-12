using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{
    private GameInformation _gameInfo;

    public void SetGame(GameInformation gameInfo)
    {
        _gameInfo = gameInfo;
        //set button text
        GetComponentInChildren<TMPro.TMP_Text>().text = _gameInfo.name;
        GetComponentInChildren<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        //TODO: Call the menu populator event

        FindObjectsByType<MenuPopulator>(FindObjectsSortMode.None)[0].UpdateFields(_gameInfo);
    }
}
