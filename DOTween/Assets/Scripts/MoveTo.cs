using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveZ(10, 2).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
