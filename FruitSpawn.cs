using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] fruitPrefabs;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    private int num;
    void Start()
    {
        InvokeRepeating("SpawnFruit", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnFruit()
    {
        num = Random.Range(0, fruitPrefabs.Length);
        //Instantiate(fruitPrefabs[num], transform.localPosition, transform.localRotation);
        Instantiate(fruitPrefabs[num]);
        if (stopSpawning)
            CancelInvoke("SpawnFruit");
    }
}
