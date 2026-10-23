using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void fadeOut()
    {
        animator.SetBool("FaderOut", true);
    }
}
