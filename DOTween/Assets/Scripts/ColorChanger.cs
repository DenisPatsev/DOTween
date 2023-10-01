using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof (Renderer))]

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Renderer _renderer;
    private int _loopsCount;

    private void Start()
    {
        _loopsCount = -1;
        _renderer = GetComponent<Renderer> ();
        _renderer.material.DOColor(Color.red, _duration).SetLoops(_loopsCount, LoopType.Yoyo);
    }
}
