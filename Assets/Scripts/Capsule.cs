using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Capsule : MonoBehaviour
{
    private float _time;
    private float _scale;
    private int _quantityRepetitions;

    private void Start()
    {
        _time = 3;
        _scale = 5;
        _quantityRepetitions = -1;

        transform.DOScale(transform.localScale.x + _scale, _time).SetLoops(_quantityRepetitions, LoopType.Restart);
    }
}
