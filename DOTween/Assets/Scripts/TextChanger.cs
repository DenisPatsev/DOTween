using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text; 

    private void Start()
    {
        _text.DOColor(Color.green, 4);
        _text.DOColor(Color.gray, 4).SetDelay(4);
        _text.DOText("Новый текст", 3, true, ScrambleMode.All).SetDelay(4);
    }
}
