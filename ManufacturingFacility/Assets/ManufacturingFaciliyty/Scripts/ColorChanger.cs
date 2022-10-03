using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 1;
    [SerializeField] private Color _secondColor;// = new Color(0, 159, 255);
    private float _timer = 0f;

    private Color _originalColor;
    private Renderer _renderer;
    private Image _image;

   
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _image = GetComponent<Image>();
        _originalColor =_renderer ? _renderer.material.color : _image.color;
    }

    // Update is called once per frame
    void Update()
    {
        Change();
    }

    private void Change()
    {

        var lerp = Mathf.PingPong(Time.time, _duration);
        if (_image) _image.color = Color.Lerp(_originalColor, _secondColor, lerp);
        if (_renderer) _renderer.material.color = Color.Lerp(_originalColor, _secondColor, lerp);
       
    }
}
