using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorDrag : MonoBehaviour
{
    private Camera cam;
    private Vector3 dragOffset;
    [SerializeField] private float speed = 10;
    private void Awake()
    {
        cam = Camera.main;
    }
    void OnMouseDown()
    {
        dragOffset = transform.position - GetMousePos();
    }

    void OnMouseDrag()
    {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + dragOffset, speed * Time.deltaTime);
    }

    Vector3 GetMousePos()
    {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
