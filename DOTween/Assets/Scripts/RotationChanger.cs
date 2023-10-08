using UnityEngine;
using DG.Tweening;

public class RotationChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _endRotationValue;
    [SerializeField] private float _duration;

    private int _loopsCount;

    private void Start()
    {
        _loopsCount = -1;
        transform.DORotate(_endRotationValue, _duration).SetLoops(_loopsCount).SetEase(Ease.Linear);
    }
}
