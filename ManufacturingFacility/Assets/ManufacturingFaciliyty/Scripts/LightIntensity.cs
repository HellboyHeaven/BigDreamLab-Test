using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightIntensity : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private float _duration;
    public IEnumerator Fade()
    {
        yield return new WaitForSeconds(_delay);
        var light = GetComponent<Light>();
        while (light.intensity <= 0) light.intensity -= Time.time/_duration;
    }
}
