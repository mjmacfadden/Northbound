using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSFX : MonoBehaviour
{
    public Collision collision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collision.Coin == true)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.Coin = false;
        }


    }
}
