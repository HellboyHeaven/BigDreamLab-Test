using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private TextMeshProUGUI _distanceText;
        
    private void Start()
    {
        _lineRenderer.gameObject.SetActive(false);
        _lineRenderer.startColor = Color.green;
        _lineRenderer.endColor = Color.red;
        _lineRenderer.startWidth = 0.01f;
        _lineRenderer.endWidth = 0.01f;
        _lineRenderer.positionCount = 2;
        _lineRenderer.useWorldSpace = true;
    }

    public void Create (Vector3 startPos, Vector3 endPos)
    {
        startPos.y = endPos.y;
        _lineRenderer.transform.position = startPos;
        _lineRenderer.SetPosition(0, startPos);
        _lineRenderer.SetPosition(1, endPos);
        _lineRenderer.gameObject.SetActive(true);
        _distanceText.text = ((endPos - startPos).magnitude * 100 ).ToString("0.0") + " cm";
        _distanceText.transform.position = (endPos + startPos) / 2;
        _distanceText.transform.gameObject.SetActive(true);

    }
}
