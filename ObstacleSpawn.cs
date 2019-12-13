using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, transform.rotation);
        if (stopSpawning)
            CancelInvoke("SpawnObstacle");
    }
}
