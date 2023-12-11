using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class CubThreeChanges : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _move;
    private float _rotate;
    private float _scale;
    private int _quantityRepetitions;

    private void Start()
    {
        _time = 5;
        _move = 3f;
        _rotate = 20.5f;
        _scale = 2f;
        _rigidbody = GetComponent<Rigidbody>();
        _quantityRepetitions = -1;

        _rigidbody.DORotate(transform.rotation.eulerAngles + Vector3.right * _rotate, _time).SetLoops(_quantityRepetitions, LoopType.Restart);
        transform.DOScale(transform.localScale.x + _scale, _time).SetLoops(_quantityRepetitions, LoopType.Restart);
        _rigidbody.DOMoveX(transform.position.x + _move, _time, false).SetLoops(_quantityRepetitions, LoopType.Restart);
    }
}
