using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float spawnTime;
    public float spawnTimeRandom;
    int numTimesHit;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        numTimesHit = 0;
        ResetSpawnTimer();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0.0f)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            ResetSpawnTimer();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            numTimesHit += 1;
        }

        if(numTimesHit >= 2)
        {
            Destroy(this.gameObject);
        }
    }

    void ResetSpawnTimer()
    {
        spawnTimer = (float)(spawnTime + Random.Range(0, spawnTimeRandom*100)/100.0);
    }
}
