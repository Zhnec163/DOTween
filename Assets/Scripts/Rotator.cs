using DG.Tweening;
using UnityEngine;

public class Rotator : DOTweenTransformation
{
    [SerializeField] private Vector3 _rotate;

    private void Start()
    {
        transform.DORotate(_rotate, Duration);
    }
}