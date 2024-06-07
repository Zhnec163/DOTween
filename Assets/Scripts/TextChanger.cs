using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 3F;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("secret file.vrml", _duration));
        sequence.Append(_text.DOText(" file not found Exception..", _duration).SetRelative());
        sequence.Append(_text.DOText("the file could not be executed on the device, definitely...", _duration, true, ScrambleMode.All));
    }
}
