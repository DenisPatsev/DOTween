using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof (Renderer))]

public class ColorChanger : MonoBehaviour
{
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer> ();
        _renderer.material.DOColor(Color.red, 4).SetLoops(-1, LoopType.Yoyo);
    }
}
