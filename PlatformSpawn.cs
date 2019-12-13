using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platformPrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    void Start()
    {
        InvokeRepeating("SpawnPlatform", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatform()
    {
        Instantiate(platformPrefab, transform.position, transform.rotation);
        if (stopSpawning)
            CancelInvoke("SpawnPlatform");
    }
}
