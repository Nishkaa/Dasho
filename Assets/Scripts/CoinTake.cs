using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
public class CoinTake : MonoBehaviour
{
    public int coin = 0;
    public TextMeshProUGUI textCoins;
    public TextMeshProUGUI textCoinsHidden;
    public TextMeshProUGUI textCoinsScore;


    public AudioSource DiamondPickUp;
    // Start is called before the first frame update
    public void Start()
    {
        // textCoinsScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        //Reset();
    }
    // Update is called once per frame
    public void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //If collided with coin take it
        if (other.gameObject.tag == "Coin")
        {
            DiamondPickUp.Play();
            coin++;
            textCoins.text = coin.ToString();
            textCoinsHidden.text = coin.ToString();
            Destroy(other.gameObject);
            //PlayerPrefs.SetInt("HighScore", coin);
        }
    }
}
