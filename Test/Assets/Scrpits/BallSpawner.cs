using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _ballGO;
    [SerializeField] private float _speed = 150;
    [SerializeField] private Transform _transform;

    public void Lauch()
    {
        _ballGO.transform.position = _transform.position;
        var direction = -_transform.right;
        var velocity = _speed * direction;
        _ballGO.GetComponent<Rigidbody>().AddForce(velocity);
    }
}