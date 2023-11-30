using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Sphere : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _speed;

    void Start()
    {
        _time = 1;
        _speed = 1;
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidbody.DOMoveX(transform.position.x + _speed, _time, false);
    }
}
