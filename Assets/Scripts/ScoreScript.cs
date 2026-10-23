using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    //public Text HighScore;
    public Text ScoreText;
    public Text HighScore;
    private int score = 0;
    public int GoalScore = 10;
    public int highScore;
    public int NextLevel = 1;
    public GameObject Fade;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        SetScores();
    }

    private void Update()
    {
        if(score >= GoalScore)
        {
            PlayerPrefs.SetInt("nextLevel", NextLevel);
            Fade.GetComponent<Animator>().SetBool("FaderOut", true);
            LoadLevel();

        }
    }

    public void LoadLevel()
    {
        Invoke("ChangeLevel", 0.5f);
    }

    public void ChangeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score = score + 1; //...then 1 is added to the variable "count" that we declared above
            if (score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HighScore", highScore);
            }
            print(highScore);
            SetScores(); //execute the SetCountText() function that we wrote below
        }
    }


    public void SetScores() //add this to display the score dynamically as it changes
    {
        HighScore.text = "high score: " + highScore.ToString();
        ScoreText.text = "score: " + score.ToString(); //this changes the data type from integer to string and adjusts the value of the UI Text object
    }
}
