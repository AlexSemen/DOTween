using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class Cub2 : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _time;
    private float _speedMove;
    private float _speedRotate;
    private float _speedScale;

    void Start()
    {
        _time = 1;
        _speedMove = 0.3f;
        _speedRotate = 2.5f;
        _speedScale = 0.2f;
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidbody.DORotate(transform.rotation.eulerAngles + Vector3.right * _speedRotate, _time);
        transform.DOScale(transform.localScale.x + _speedScale, _time);
        _rigidbody.DOMoveX(transform.position.x + _speedMove, _time, false);
    }
}
