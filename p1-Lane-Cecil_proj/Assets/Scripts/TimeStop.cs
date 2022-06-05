using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool restoreTime;

    // Start is called before the first frame update
    void Start()
    {
        restoreTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (restoreTime)
        {
            if(Time.timeScale< 1f)
            {
                Time.timeScale += Time.deltaTime * speed;
            }
            else
            {
                Time.timeScale = 1f;
                restoreTime = false;
            }
        }
    }

    public void StopTime(float changeTime, int restoreSpeed, float delay)
    {
        speed = restoreSpeed;

        if (delay > 0)
        {
            StopCoroutine(StartTimeAgain(delay));
            StartCoroutine(StartTimeAgain(delay));
        }
        else
        {
            restoreTime = true;
        }

        Time.timeScale = changeTime;
    }

    IEnumerator StartTimeAgain(float amount)
    {
        yield return new WaitForSecondsRealtime(amount);
        restoreTime = true;
    }
}