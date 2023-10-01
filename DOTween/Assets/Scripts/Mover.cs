using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;

    private int _loopsCount;
    private float _endValue;

    private void Start()
    {
        _loopsCount = -1;
        _endValue = 1;
        transform.DOMoveZ(-_endValue, _duration).SetLoops(_loopsCount, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
