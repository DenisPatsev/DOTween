using UnityEngine;
using DG.Tweening;

public class RotationChanger : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0, 180, 0), 5).SetLoops(-1).SetEase(Ease.Linear);
    }
}
