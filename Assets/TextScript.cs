using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class TextScript : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _delay;
    private int _timeChange;
    private int _timeChangeColor;

    private void Awake()
    {
        _delay = 3;
        _timeChange = 2;
        _timeChangeColor = 1;
    }

    private void Start()
    {
        StartCoroutine(ChangeText());
    }

    private IEnumerator ChangeText()
    {
        var waitForDelay = new WaitForSeconds(_delay);

        _text.DOText("Замена", _timeChange);

        yield return waitForDelay;

        _text.DOText(" Добавление", _timeChange).SetRelative();

        yield return waitForDelay;

        _text.DOColor(Color.red, _timeChangeColor).SetLoops(-1, LoopType.Yoyo);
        _text.DOText("Текст Взломан", _timeChange, true, ScrambleMode.All);
    }
}
