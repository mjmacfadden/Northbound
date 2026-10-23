using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearData : MonoBehaviour
{
    public ScoreScript scoreScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            clearData();
        }
    }
    public void clearData()
    {
        PlayerPrefs.DeleteAll();
        scoreScript.highScore = 0;
        scoreScript.SetScores();
    }
}
