using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _endScaleValue;
    [SerializeField] private float _duration;

    private int _loopsCount;

    private void Start()
    {
        _loopsCount = -1;
        transform.DOScale(_endScaleValue, _duration).SetLoops(_loopsCount, LoopType.Yoyo);
    }
}
