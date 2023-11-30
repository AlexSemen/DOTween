using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Capsule : MonoBehaviour
{
    private float _time;
    private float _speed;

    void Start()
    {
        _time = 1;
        _speed = 1;
    }

    void Update()
    {
        transform.DOScale(transform.localScale.x + _speed, _time);
    }
}
