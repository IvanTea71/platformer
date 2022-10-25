using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigitbody2d;
    [SerializeField] private float _jumpForce;

    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigitbody2d.AddForce(Vector2.up * _jumpForce);
        }
    }
}
