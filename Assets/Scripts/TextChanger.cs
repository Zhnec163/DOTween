using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : DOTweenTransformation
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("secret file.vrml", Duration));
        sequence.Append(_text.DOText(" file not found Exception..", Duration).SetRelative());
        sequence.Append(_text.DOText("the file could not be executed on the device, definitely...", Duration, true, ScrambleMode.All));
    }
}
