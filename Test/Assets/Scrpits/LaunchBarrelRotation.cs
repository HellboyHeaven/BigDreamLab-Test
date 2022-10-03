using UnityEngine;
using UnityEngine.UI;

public class LaunchBarrelRotation : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private int _degree;
    
    public void SetDegree(Slider slider)
    {
        _degree = (int)slider.value;
        _transform.localEulerAngles = new Vector3(-90 + _degree, 90, -90);
    } 
}
