using DG.Tweening;
using UnityEngine;

public class Mover : DOTweenTransformation
{
    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        transform.DOMove(_targetPosition, Duration);
    }
}
