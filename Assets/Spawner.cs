using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float spawnRate = 1;
    public float spawnRadius = 1;

    private float lastSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - this.lastSpawnTime > this.spawnRate)
        {
            this.lastSpawnTime = Time.time;
            this.spawn();
        }
    }

    private void spawn()
    {
        var spawnPos = this.transform.position;
        spawnPos.x += Random.Range(-this.spawnRadius, this.spawnRadius);
        spawnPos.y += Random.Range(-this.spawnRadius, this.spawnRadius);
        Instantiate(this.prefab, spawnPos, Quaternion.identity);
    }
}
