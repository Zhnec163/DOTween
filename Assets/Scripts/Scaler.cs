using DG.Tweening;
using UnityEngine;

public class Scaler : DOTweenTransformation
{
    [SerializeField] private float _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration);
    }
}
