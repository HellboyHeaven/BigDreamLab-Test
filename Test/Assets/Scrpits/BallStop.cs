using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStop : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private Transform _ballSpawn;
    //[SerializeField] private LineDrawer _lineDrawer;
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Ball")
        {
            //Destroy(col.gameObject.GetComponent<Rigidbody>());
            //_lineDrawer.Create(_ballSpawn.position, col.transform.position);
        }
    }
}
