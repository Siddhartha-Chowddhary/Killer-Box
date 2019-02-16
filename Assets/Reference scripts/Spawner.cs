using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Enemy;
    public Transform[] SpawnSpots;
    public float TimetoReSpawn;
    public float StartSpawning;

    void Start()
    {
        TimetoReSpawn = StartSpawning;

    }

    void Update()
    {
        if (TimetoReSpawn <= 0)
        {
            int randPos = Random.Range(0, SpawnSpots.Length - 1);
            Instantiate(Enemy, SpawnSpots[randPos].position, Quaternion.identity);
            TimetoReSpawn = StartSpawning;
        }
        else
        {
            TimetoReSpawn -= Time.deltaTime;
        }
    }
}
