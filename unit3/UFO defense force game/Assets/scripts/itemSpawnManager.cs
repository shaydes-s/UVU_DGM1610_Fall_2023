using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawnBehavior : MonoBehaviour
{
    private float spawnRangeX = 20f;
    private float spawnPosZ = 30f;
    private float spawnInterval = 5f;
    private float startDelay = 5f;
    [SerializeField] public GameObject collectible;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItem", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnItem()
    {
        Vector3 spawnPosItem = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,(Random.Range(10, spawnPosZ))); //picks a random place to spawn
        GameObject myCollectible =
        Instantiate(collectible, spawnPosItem, collectible.transform.rotation); //spawns item?
    }
}
