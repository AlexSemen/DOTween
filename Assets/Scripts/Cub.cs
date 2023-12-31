using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Cub : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _rotate;
    private int _quantityRepetitions;

    private void Start()
    {
        _time = 3; 
        _rotate = 180;
        _rigidbody = GetComponent<Rigidbody>();
        _quantityRepetitions = -1;

        _rigidbody.DORotate(transform.rotation.eulerAngles + Vector3.right * _rotate, _time).SetLoops(_quantityRepetitions, LoopType.Restart);
    }
}
