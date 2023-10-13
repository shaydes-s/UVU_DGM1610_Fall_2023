using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store ufo ships
    private float spawnRangeX = 20f;
    private float spawnPosZ = 30f;
    private float startDelay = 4f;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ); //picks a random place to spawn
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //picks random ufo from 0-number of ufos in array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //spawns ufo
    }
}