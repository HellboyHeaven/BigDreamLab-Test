using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseController : MonoBehaviour
{
    [SerializeField] private Transform _spawn;
    public void Home()
    {
        transform.position = _spawn.transform.position;
    }
}
