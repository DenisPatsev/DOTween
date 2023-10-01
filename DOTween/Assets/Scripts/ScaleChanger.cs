using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _xComponent;
    [SerializeField] private float _yComponent;
    [SerializeField] private float _zComponent;
    [SerializeField] private float _duration;

    private int _loopsCount;

    private void Start()
    {
        _loopsCount = -1;
        transform.DOScale(new Vector3(_xComponent, _yComponent, _zComponent), _duration).SetLoops(_loopsCount, LoopType.Yoyo);
    }
}
