using UnityEngine;

public class LauncherSlot : MonoBehaviour
{
    [SerializeField] private GameObject _launcherGO;
    private bool _isFirst = true;

    private Ray _ray;
    private RaycastHit _hit;

    public void OnBeginDrag()
    {
        _ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        
        if (Physics.Raycast(_ray, out _hit) && _isFirst)
        {
            _launcherGO.transform.position = _hit.point;
            _launcherGO.SetActive(true);
            _launcherGO.GetComponent<Collider>().enabled = false;
        }
       
    }

    public void OnDrag()
    {
        _ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        if (Physics.Raycast(_ray, out _hit))
        {
            _launcherGO.transform.position = Vector3.MoveTowards(_launcherGO.transform.position, _hit.point, 2 * Time.deltaTime);
        }
    }

    public void OnEndDrag()
    {

        if (_hit.transform.tag == "Placeholder")
        {
            _isFirst = false;
            //Debug.Log("AA");
            _launcherGO.transform.position = _hit.transform.position;
            _hit.transform.GetComponent<SpriteRenderer>().enabled = false;
            _launcherGO.GetComponent<Collider>().enabled = true;

        }
        else _launcherGO.SetActive(false);
    }

}
