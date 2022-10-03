using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class BlinkData : ScriptableObject
{
    
    [SerializeField] public float Duration;
    [SerializeField] public Material Material;
    [SerializeField] public Color Color1;
    [SerializeField] public Color Color2;
}
