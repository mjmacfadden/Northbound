using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Projectile;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            {
                nextSpawn = Time.time + spawnRate;
                randY = Random.Range(-10.79f, 10.79f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(Projectile, whereToSpawn, Quaternion.identity);
            }
        }
    }
}