using UnityEngine;
using TMPro;

public class CounterScript : MonoBehaviour
{
    private TextMeshProUGUI _counterText;

    public void ShowCount (int count)
    {
        _counterText = GetComponentInChildren<TextMeshProUGUI>();
        _counterText.text = count.ToString();
    }
}
