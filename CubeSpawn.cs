using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubePrefab;
    public int cubeCount;
    public Vector3 currentPos = new Vector3(-1f, 0.55f, 2f);
    public float spawnDistance = 5f;

    void Start()
    {
        Instantiate(cubePrefab, cubePrefab.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
