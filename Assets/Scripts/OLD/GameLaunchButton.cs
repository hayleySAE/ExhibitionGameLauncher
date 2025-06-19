using System.Diagnostics;
using UnityEngine;

public class GameLaunchButton : MonoBehaviour
{
    //TODO:Move to game panel
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string filePath;
    
    public void LaunchGame()
    {
        if (filePath.Length > 0)
        {
            print(filePath);
            /*
            Process load = new Process();
            load.StartInfo.FileName = filePath;//for executable files
            load.Start();
            */
        }
    }
}
