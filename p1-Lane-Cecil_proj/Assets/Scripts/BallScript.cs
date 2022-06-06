using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private GameObject gm;
    private AudioManager am;
    [SerializeField] private Vector2 ballVelocity;
    private LineRenderer lr;
    private Rigidbody2D rb;
    private GameObject anchor;
    private Transform target;
    [SerializeField] private float smoothTime;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [SerializeField] private TimeStop timeStop;
    [SerializeField] float hitChangeTime = 0.05f;
    [SerializeField] int hitRestoreSpeed = 10;
    [SerializeField] float hitDelay = 0.1f;

    private void Awake()
    {
        gm = GameObject.Find("Game Manager");
        am = gm.GetComponent<AudioManager>();
        lr = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
        timeStop = GetComponent<TimeStop>();
        anchor = GameObject.Find("Anchor");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = anchor.transform.TransformPoint(new Vector3(0, 0, 0));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        ballVelocity = rb.velocity;
    }

    private void LateUpdate()
    {
        DrawRope();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Rotation>())
        {
            timeStop.StopTime(hitChangeTime, hitRestoreSpeed, hitDelay);
        }

        if (collision.gameObject.CompareTag("Square"))
        {
            am.Play("Hit_1");
        }
        if (collision.gameObject.CompareTag("Diamond"))
        {
            am.Play("Hit_2");
        }
        if (collision.gameObject.CompareTag("Pill"))
        {
            am.Play("Hit_3");
        }
    }

    void DrawRope()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, anchor.transform.position);
    }
}
