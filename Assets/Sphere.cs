using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Sphere : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _distance;
    private int quantityRepetitions;

    private void Start()
    {
        _time = 5;
        _distance = 10;
        _rigidbody = GetComponent<Rigidbody>();
        quantityRepetitions = -1;

        _rigidbody.DOMoveX(transform.position.x + _distance, _time, false).SetLoops(quantityRepetitions, LoopType.Restart);
    }
}
