using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "GameInformation", menuName = "Scriptable Objects/GameInformation")]
public class GameInformation : ScriptableObject
{
    [SerializeField]
    public string gameName;

    // game name
    // student names
    // description
    // image
    // filepath
}
