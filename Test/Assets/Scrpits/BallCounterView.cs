using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BallCounterView : MonoBehaviour
{
    [SerializeField] private int _count = 0;
    private TextMeshProUGUI _text;
    public int Count { get { return _count; }}

    private void UpdateText() => _text.text = _count.ToString();
    public void AddCount()
    {
        _count++;
        UpdateText();
    }
    public void RemoveCount()
    {
        _count = _count > 0 ? --_count : 0;
        UpdateText();
    }
    
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

}
