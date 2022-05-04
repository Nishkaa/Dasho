using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject ground;
    public GameObject spikeGround;
    public GameObject spikeGroundBackwards;
    public GameObject Coin;
    public GameObject Background;
    public GameObject Razor;

    private Vector3 SpawnTile;
    public float SpawnTime = 0.6f;
    public float bgSpawnTime = 0.1f;
    public float distance;
    public float CoinDistance;
    public float BackgroundDistance;
    public CountDownT countDownTimer;
    public void Awake()
    {

    }
    public void Start()
    {
        Spawn();
        BackgroundSpawn();
    }
    public void Update()
    {

    }
    //spawning tiles
    public void Spawn()
    {
        //spawning coins
        var coins = Instantiate(Coin, new Vector2(CoinDistance, 1), Quaternion.identity);
        CoinDistance += 10;

        //spawning ground
        var groundClone = Instantiate(ground, new Vector2(distance, -2), Quaternion.identity);
        groundClone.transform.localScale = new Vector3(Random.Range(5, 15), 1, 1);
        distance += 20;

        //spawning  spike ground
        var groundCloneSpike = Instantiate(spikeGround, new Vector2(distance, -2), Quaternion.identity);
        groundCloneSpike.transform.localScale = new Vector3(10, 1, 1);
        distance += 15;

        //spawning  spike ground backwards
        var groundSpikeBackwards = Instantiate(spikeGroundBackwards, new Vector2(distance, -2), Quaternion.identity);
        groundCloneSpike.transform.localScale = new Vector3(10, 1, 1);
        distance += 15;

        var RazorSpike = Instantiate(Razor, new Vector2(distance, -2), Quaternion.identity);
        RazorSpike.transform.localScale = new Vector3(10, 1, 1);
        distance += 15;

        //Destroy after 60 seconds
        Destroy(groundClone, 60);
        Destroy(coins, 60);

        //spawn cooldown
        StartCoroutine(Spawner());
    }
    public void BackgroundSpawn()
    {
        //spawning background
        var background = Instantiate(Background, new Vector2(BackgroundDistance, 0), Quaternion.identity);
        BackgroundDistance += 15;

        Destroy(background, 60);
        //spawn cooldown
        StartCoroutine(BackgroundSpawner());
    }
    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(SpawnTime);
        Spawn();
    }
    IEnumerator BackgroundSpawner()
    {
        yield return new WaitForSeconds(bgSpawnTime);
        BackgroundSpawn();
    }

}
