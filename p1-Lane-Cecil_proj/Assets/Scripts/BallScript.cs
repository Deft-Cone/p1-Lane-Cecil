using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private LineRenderer lr;
    [SerializeField] private GameObject anchor;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    [SerializeField] private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        anchor = GameObject.Find("Anchor");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = anchor.transform.TransformPoint(new Vector3(0, -2, 0));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

    private void LateUpdate()
    {
        DrawRope();
    }

    void DrawRope()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, anchor.transform.position);
    }
}
