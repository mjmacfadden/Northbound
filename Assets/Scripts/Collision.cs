using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public float CollisionShake = 1f;
    public GameObject CollisionGraphic;
    public HealthBar other;
    public string nextLevel = "Level_01";
    public bool Coin = false;

    public float health = 8;

    private void Update()
    {
        if (health < 1f)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(nextLevel);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            CameraShake.shakeDuration = CollisionShake;
            CollisionGraphic.SetActive(true);
            Invoke("Flash", .1f);
            other.moveHealthBar();
            health = health - 1f;
            //print(health);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
        else if (coll.gameObject.CompareTag("Ground"))
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Coin = true;
        }

    }
    void Flash()
    {
        CollisionGraphic.SetActive(false);
    }
}
