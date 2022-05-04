using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UI;
using System;
public class ChronoMeter : MonoBehaviour
{
    float currentTime = 180f;
    float startingTime = 10f;

    public bool timerActive = false;
    public float ChronoTime;
    public GameObject ChronoTimeSave;
    public GameObject RunningMeter;
    public GameObject Diamonds;
    public TextMeshProUGUI chronoMeter;
    public TextMeshProUGUI LastTime;

    // Start is called before the first frame update
    void Start()
    {
        ChronoTimeSave.SetActive(false);
        RunningMeter.SetActive(true);
        Diamonds.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartChrono();
        ChronoCheck();
        BestTime();
    }
    public void ChronoCheck()
    {

        if (timerActive == true)
        {
            ChronoTime += 1 * Time.deltaTime;
            TimeSpan time = TimeSpan.FromMinutes(ChronoTime);
            chronoMeter.text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();
        }

        PlayerPrefs.SetFloat("BestChrono", ChronoTime);
    }
    public void BestTime()
    {
        if (GameObject.FindWithTag("Player") == null)

        {
            ChronoTimeSave.SetActive(true);
            Diamonds.SetActive(true);
            RunningMeter.SetActive(false);
            timerActive = false;
            LastTime.text = PlayerPrefs.GetFloat("BestChrono").ToString();
        }
    }
    public void StartChrono()
    {
        timerActive = true;
    }
    public void StopChrono()
    {
        timerActive = false;
        LastTime.text = PlayerPrefs.GetFloat("BestChrono").ToString();
    }
}
