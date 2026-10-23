using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{

    public string nextLevel = "Level_01";

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
