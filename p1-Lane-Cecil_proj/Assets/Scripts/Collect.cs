using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Collect : MonoBehaviour
{
    public GameObject square;
    public GameObject diamond;
    public GameObject pill;
    
    void OnCollisionEnter2D(Collision2D itemType)
    {
        Debug.Log("uh");
        if (itemType.collider.tag == "Square")
        {
            Debug.Log("collected!");
            square.gameObject.SetActive(false);
        }
        else if (itemType.collider.tag == "Diamond")
        {
            Debug.Log("collected!");
            diamond.gameObject.SetActive(false);
        }
        else {
            Debug.Log("collected!");
            pill.gameObject.SetActive(false);
        }
    }
    
}