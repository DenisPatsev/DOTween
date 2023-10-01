using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _scrambleDuration;
    [SerializeField] private float _delay;

    private void Start()
    {
<<<<<<< HEAD
        _text.DOColor(Color.green, _duration);
        _text.DOColor(Color.gray, _duration).SetDelay(_delay);
        _text.DOText("New text", _scrambleDuration, true, ScrambleMode.All).SetDelay(_delay);
=======
        _text.DOColor(Color.green, 4);
        _text.DOColor(Color.gray, 4).SetDelay(4);
        _text.DOText("New text", 3, true, ScrambleMode.All).SetDelay(4);
>>>>>>> origin/main
    }
}
