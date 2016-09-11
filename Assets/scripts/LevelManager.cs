using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    //Needs to be public to be accessed by Unity
    public void LoadLevel(string levelName)
    {
        Debug.Log("Level load requested for " + levelName);
        Application.LoadLevel(levelName);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}