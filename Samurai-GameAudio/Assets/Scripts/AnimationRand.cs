using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRand : MonoBehaviour
{
    public Animator m_Animator;

    void Start()
    {
        m_Animator.speed = Random.Range(0.7f,1.2f);
    }
    
}


  