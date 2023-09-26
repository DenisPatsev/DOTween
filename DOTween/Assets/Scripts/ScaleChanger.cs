using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(2, 2, 2), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
