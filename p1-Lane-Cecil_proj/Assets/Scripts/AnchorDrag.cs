using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorDrag : MonoBehaviour
{
    private Camera cam;
    private Vector3 dragOffset;
    [SerializeField] private float speed = 10;
    [SerializeField] private float smoothTime;
    [SerializeField] Vector3 velocity = Vector3.zero;
    private void Awake()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        
    }
    void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
    }

    void OnMouseDrag()
    {
        
        transform.position = Vector3.SmoothDamp(transform.position, GetMousePos() + dragOffset, ref velocity, smoothTime * Time.deltaTime);
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
