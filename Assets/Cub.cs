using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Cub : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _speed;

    void Start()
    {
        _time = 1; 
        _speed = 5;
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidbody.DORotate(transform.rotation.eulerAngles + Vector3.right * _speed, _time);
    }
}
