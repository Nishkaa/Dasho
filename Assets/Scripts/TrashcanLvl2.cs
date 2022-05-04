using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UI;
using System;
public class TrashcanLvl2 : MonoBehaviour
{
    public GameObject TryAgain;
    public GameObject PressSpace;
    public bool pause = false;
    public AudioSource JumpDeath;
    public ChronoMeter Chrono;
    public void Start()
    {
        pause = false;
        TryAgain.SetActive(false);
        PressSpace.SetActive(false);

    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space) && pause == true)
        {
            SceneManager.LoadScene("Level02");
            Time.timeScale = 1;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PauseGame();

            TryAgain.SetActive(true);
            PressSpace.SetActive(true);
            JumpDeath.Play();
            Destroy(collision.gameObject);
            //SceneManager.LoadScene("Level01");
        }

    }
    void PauseGame()
    {
        pause = true;
        Time.timeScale = 0;

    }
}
