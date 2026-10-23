using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiator : MonoBehaviour
{
    public float gravityScale = 2.5f;
    public float startInitiation = .5f;
    public GameObject coinSpawner;
    public GameObject enemySpawner;


    private void Start()
    {
        Invoke("initiate", startInitiation);
    }

    void initiate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravityScale;
        GetComponent<FlyScript>().enabled = true;
        enemySpawner.SetActive(true);
        coinSpawner.SetActive(true);
    }


}
