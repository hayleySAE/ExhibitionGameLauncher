using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameInformation", menuName = "Scriptable Objects/GameInformation")]
public class GameInformation : ScriptableObject
{
    [Header("Keep to under 75 characters")]
    [SerializeField] public string gameName;
    [Header("List the names and roles of all students")]
    [SerializeField] public List<StudentInfo> studentNames;
    [Header("Keep to under 50 words/ 360 characters")]
    [SerializeField] public string description;
    [Header("Sprite with 16:9 aspect ratio")]
    [SerializeField] public Sprite icon;
    [Header("Relative path from build folder to target executable including executable type")]
    [SerializeField] public string filePath;
}
