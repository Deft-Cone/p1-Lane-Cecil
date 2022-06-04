using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private LineRenderer lr;
    [SerializeField] private GameObject anchor;

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
