using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _duration = 3F;

    private void Start()
    {
        _text1.DOText("secret file.vrml", _duration);
        _text2.DOText(" file not found Exception..", _duration).SetRelative();
        _text3.DOText("the file could not be executed on the device, definitely...", _duration, true, ScrambleMode.All);
    }
}
