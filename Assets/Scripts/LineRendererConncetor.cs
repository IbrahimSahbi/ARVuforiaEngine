using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererConncetor : MonoBehaviour
{
    public Transform FirstConnector;
    public Transform SecondConnector;
    private LineRenderer lineRenderer;
    private void Start()
    {
        lineRenderer = GetComponentInChildren<LineRenderer>();
        
    }
    private void FixedUpdate()
    {
        lineRenderer.SetPosition(0,FirstConnector.localPosition) ;
        lineRenderer.SetPosition(1, SecondConnector.localPosition) ;
    }
}
