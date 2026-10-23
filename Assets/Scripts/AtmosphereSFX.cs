using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtmosphereSFX : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
