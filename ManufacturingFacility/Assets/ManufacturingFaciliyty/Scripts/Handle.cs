using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour
{
    private bool _locked = true;
    public bool CanShot { get; private set; } = false;
    public void UnLockShot()
    {
        _locked = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Hand")
        {
            CanShot = _locked? false: true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            CanShot = false;
        }
    }
}
