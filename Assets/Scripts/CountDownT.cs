using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class CountDownT : MonoBehaviour
{
    public GameObject HiddenScore;
    public GameObject LevelComplete;
    public GameObject TryAgain;

    public float currentTime = 60f;
    public float startingTime = 10f;
    public bool timerActive = false;

    public CoinTake coinT;

    [SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    public void Start()
    {
        HiddenScore.SetActive(false);
        LevelComplete.SetActive(false);
        TryAgain.SetActive(false);
        //  HiddenHighScore.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        CoundDownCheck();
    }

    //COUNTDOWN TIMER
    public void CoundDownCheck()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (coinT.coin >= 60)
        {
            PauseGame();
            CompleteLevel();

            if (coinT.coin < 60)
            {
                TryAgain.SetActive(true);
            }

            LevelComplete.SetActive(true);
            currentTime = 0;

            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("Level01");
                Time.timeScale = 1;
            }
        }

    }
    public void CompleteLevel()
    {
        HiddenScore.SetActive(true);
        //  HiddenHighScore.SetActive(true);

    }
    //Pause the actual game
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        //Time.timeScale = 1;
    }
}
