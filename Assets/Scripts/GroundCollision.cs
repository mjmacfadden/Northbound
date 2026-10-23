using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollision : MonoBehaviour
{
    public GameObject Thomas;
    public string nextLevel = "Level_01";

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            print("Ground Collide");
            GroundCollide();
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            Invoke("ChangeLevel", .5f);

        }
    }
    void GroundCollide()
    {
        Thomas.GetComponent<ParticleSystem>().Play();
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(nextLevel); //this restarts the current level
    }
}
