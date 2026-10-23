using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{

    public Button level02;
    public Button level03;
    public Button level04;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("nextLevel") == 1)
        {
            level02.interactable = true;
        }
        if (PlayerPrefs.GetInt("nextLevel") == 2)
        {
            level02.interactable = true;
            level03.interactable = true;
        }
        if (PlayerPrefs.GetInt("nextLevel") == 3)
        {
            level02.interactable = true;
            level03.interactable = true;
            level04.interactable = true;
        }
    }


}
