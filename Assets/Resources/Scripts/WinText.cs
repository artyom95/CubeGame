using DG.Tweening;
using TMPro;
using UnityEngine;

public class WinText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _textLabel;
    
    [SerializeField]
    private float _targetValue = 1;
    
    [SerializeField]
    private float _duration = 3;

    public void Show()
    {
        _textLabel.rectTransform.DOScale(_targetValue, _duration);
    }
}