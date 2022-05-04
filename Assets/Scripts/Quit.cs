using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UI;
using System;
public class Quit : MonoBehaviour
{

    public void ExitGame()
    {
        //Exit Game
        Application.Quit();

    }
    public void EnterGame()
    {
        //Load Level
        SceneManager.LoadScene("Level01");
    }
    public void EnterGameLevel02()
    {
        //Load Level
        SceneManager.LoadScene("Level02");
    }
    public void Settings()
    {
        //insert Settings
        SceneManager.LoadScene("Settings");
    }
    public void Credits()
    {
        //insert Credits
        SceneManager.LoadScene("Credits");
    }
    public void GameModes()
    {
        SceneManager.LoadScene("GameModes");
    }
}
