using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour
{
    private Animator _animator;
        
    void Start()
    {
        _animator = GetComponent<Animator>(); 
    }

    private void Update()
    {
        float speed = 1;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            _animator.SetFloat("Speed", speed);
        }
        else
        {
            speed = 0;
            _animator.SetFloat("Speed", speed);
        }
    }
}
