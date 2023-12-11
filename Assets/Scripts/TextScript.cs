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
    private int _quantityRepetitions;
    private bool _isWork;
    private string _defaultText;
    private Color _defaultColor;

    private void Awake()
    {
        _delay = 3;
        _timeChange = 2;
        _timeChangeColor = 1;
        _quantityRepetitions = -1;
        _isWork = true;

        _defaultText = _text.text;
        _defaultColor = _text.color;
    }

    private void Start()
    {
        StartCoroutine(ChangeText());
    }

    private IEnumerator ChangeText()
    {
        var waitForDelay = new WaitForSeconds(_delay);

        while (_isWork)
        {
            yield return waitForDelay;

            _text.DOText("Замена", _timeChange);

            yield return waitForDelay;

            _text.DOText(" Добавление", _timeChange).SetRelative();

            yield return waitForDelay;

            _text.DOColor(Color.red, _timeChangeColor).SetLoops(_quantityRepetitions, LoopType.Yoyo);
            _text.DOText("Текст Взломан", _timeChange, true, ScrambleMode.All);

            yield return waitForDelay;

            DOTween.KillAll();
            _text.text = _defaultText;
            _text.color = _defaultColor;
        }
    }
}
