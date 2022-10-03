using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Extinguishing : MonoBehaviour
{
    [SerializeField]
    private void OnParticleCollision(GameObject other)
    {
        
        if (other.tag == "Fire")
        {
            other.GetComponent<ParticleSystem>()?.Stop();
            other.SetActive(false);
        }
    }



}
