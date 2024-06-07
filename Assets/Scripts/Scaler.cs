using DG.Tweening;
using UnityEngine;

public class Scaler : Transformator
{
    [SerializeField] private float _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration);
    }
}
