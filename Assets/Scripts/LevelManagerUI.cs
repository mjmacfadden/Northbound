using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerUI : MonoBehaviour
{

    private Animator animator; 

    void Awake()
    {
        animator = GetComponent<Animator>();
    }


    public void levelMenu()
    {
        animator.SetBool("moveCam", true);
    }

    public void mainMenu()
    {
        animator.SetBool("moveCam", false);
    }
}
