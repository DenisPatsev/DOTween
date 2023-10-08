using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _scrambleDuration;
    [SerializeField] private float _delay;

    private string _changedText;

    private void Start()
    {
        _changedText = "New text";
        _text.DOColor(Color.green, _duration);
        _text.DOColor(Color.gray, _duration).SetDelay(_delay);
        _text.DOText(_changedText, _scrambleDuration, true, ScrambleMode.All).SetDelay(_delay);
    }
}
