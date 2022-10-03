using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Blink1 : MonoBehaviour
{
    [SerializeField] public bool ActiveOnBegin;
    [SerializeField] private BlinkData data;

    private Material _originalMaterial;
    private Renderer _renderer;
   
    private bool _active = false;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _originalMaterial = _renderer.sharedMaterial;
        //_renderer.material = data.Material;
        if(ActiveOnBegin) Begin();
    }

    private void Update()
    {
        
       if(_active) _renderer.material.color = Color.Lerp(data.Color1, data.Color2, Mathf.PingPong(Time.time, data.Duration));
       
    }

    public void Begin()
    {
        _renderer.material = data.Material;
        _active = true;
    }

    public void End()
    {
        _active = false;
        _renderer.material = _originalMaterial;
    }


}
