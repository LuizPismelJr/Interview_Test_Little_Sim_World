using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public void LevelToChange(string levelName)
    {
        LevelManager.instance.LoadLevel(levelName);
    }

    public void ExitingGame()
    {
        Application.Quit();
    }
}
