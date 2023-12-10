using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cylinder : MonoBehaviour
{
    private float _time;
    private int quantityRepetitions;

    private void Start()
    {
        _time = 5;
        quantityRepetitions = -1;

        GetComponent<MeshRenderer>().material.DOColor(Color.red, _time).SetLoops(quantityRepetitions, LoopType.Restart);
    }
}
